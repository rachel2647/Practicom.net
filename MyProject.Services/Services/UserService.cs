using AutoMapper;
using MyProject.Common.DTO_s;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDTO> AddAsync(UserDTO userDTO)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(userDTO)));
        }
        public async Task<UserDTO> GetByIdAsync(string userId)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(userId));
        }
    }
}
