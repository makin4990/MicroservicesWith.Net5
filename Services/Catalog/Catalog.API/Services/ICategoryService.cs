using Catalog.API.Dtos;
using Catalog.API.Models;
using SharedLibrary.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> GetByIdAsync(string id);
        Task<Response<CategoryDto>> CreateAsync(Category category);

    }
}