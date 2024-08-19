﻿using Biblioteca.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL.Interfaces
{
    public interface IEditorialRepository
    {
        public Task<List<Editorial>> GetEditorialesAsync();
        public Task<Editorial> GetEditorialByIdAsync(int id);
        public Task<int> InsertEditorialAsync(Editorial Editorial);
        public Task<Editorial> UpdateEditorialAsync(Editorial Editorial);
        public Task<bool> DeleteEditorialAsync(int id);
    }
}
