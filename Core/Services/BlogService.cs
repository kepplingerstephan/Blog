using Core.Interfaces;
using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
	public class BlogService : IBlogService
	{
		public Task<int> CreateAsync(BlogCreateEditDto entity)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<BlogDto>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<BlogDto> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task SaveAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAsync(BlogCreateEditDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
