﻿using AutoMapper;
using Biblioteca.BL.Interfaces;
using Biblioteca.DAL.Interfaces;
using Biblioteca.Entities.DTO;
using Biblioteca.Entities.Models;

namespace Biblioteca.BL
{
    public class EditorialService : IEditorialService
    {
        private readonly IEditorialRepository repository;
        private readonly IMapper mapper;

        public EditorialService(IEditorialRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<EditorialDto>> GetEditorialesAsync()
        {
            try
            {
                var result = await repository.GetEditorialesAsync();
                return mapper.Map<List<EditorialDto>>(result);
            }
            catch (Exception)
            {
                return new List<EditorialDto>();
            }
        }

        public async Task<EditorialDto> GetEditorialByIdAsync(int id)
        {
            try
            {
                var result = await repository.GetEditorialByIdAsync(id);
                return mapper.Map<EditorialDto>(result);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> InsertEditorialAsync(EditorialDto model)
        {
            try
            {
                var entity = mapper.Map<EditorialDto, Editorial>(model);
                return await repository.InsertEditorialAsync(entity);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<EditorialDto> UpdateEditorialAsync(EditorialDto model)
        {
            try
            {
                var entity = mapper.Map<EditorialDto, Editorial>(model);
                var result = await repository.UpdateEditorialAsync(entity);
                return mapper.Map<EditorialDto>(result);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> DeleteEditorialAsync(int id)
        {
            try
            {
                return await repository.DeleteEditorialAsync(id);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}