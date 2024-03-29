﻿using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Gateways.External;
using System;
using System.Collections.Generic;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class PostPedidoUseCaseAsync : IUseCaseAsync<PedidoPostRequest, Tuple<int, Guid>>
    {
        private readonly IPedidoGateway _pedidoGateway;
        private readonly IPagamentoGateway _pagamentoGateway;
        private readonly IProdutoGateway _produtoGateway;
        private readonly IMapper _mapper;

        public PostPedidoUseCaseAsync(IPedidoGateway pedidoGateway, IMapper mapper, IPagamentoGateway pagamentoGateway, IProdutoGateway produtoGateway)
        {
            _pedidoGateway = pedidoGateway;
            _mapper = mapper;
            _pagamentoGateway = pagamentoGateway;
            _produtoGateway = produtoGateway;
        }

        public async Task<Tuple<int, Guid>> ExecuteAsync(PedidoPostRequest request)
        {
            if (request.Produtos == null || request.Produtos.Count == 0)
                throw new ArgumentException("Dados do pedido são inválidos");

            var pedido = new Pedido();
            pedido.AddPagamento(request.Pagamento.Tipo);

            foreach (var item in request.Produtos)
            {
                var produto = await _produtoGateway.GetAsync(item.ProdutoId);
                if (produto == null)
                    throw new KeyNotFoundException("Produto não encontrado");

                var itemPedido = new ItemPedido(pedido.Id, item.ProdutoId, item.Observacao);
                pedido.AddItemPedido(itemPedido);
            }

            pedido = await _pedidoGateway.AddAsync(pedido);
            return new Tuple<int, Guid>(pedido.Senha, pedido.Pagamento.Id);
        }
    }
}
