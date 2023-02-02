using Core.Interfaces;
using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
	public class UserService : IUserService
	{
		public Task<int> CreateAsync(UserCreateEditDto entity)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<UserDto>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<UserDto> GetByIdAsync(int id)
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

		public Task<bool> UpdateAsync(UserCreateEditDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
