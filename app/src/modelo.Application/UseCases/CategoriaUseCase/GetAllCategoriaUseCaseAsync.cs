﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.CategoriaModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.CategoriaUseCase
{
    public class GetAllCategoriaUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<CategoriaResponse>>
    {
        private readonly ICategoriaGateway categoriaGateway;
        private readonly IMapper mapper;


        public GetAllCategoriaUseCaseAsync(ICategoriaGateway clienteGateway, IMapper mapper)
        {
            categoriaGateway = clienteGateway;
            this.mapper = mapper;

        }

        public async Task<IEnumerable<CategoriaResponse>> ExecuteAsync()
        {
            var result = await categoriaGateway.GetAllAsync();

            return mapper.Map<IEnumerable<CategoriaResponse>>(result);
        }
    }
}