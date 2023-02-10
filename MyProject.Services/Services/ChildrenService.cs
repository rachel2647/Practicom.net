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
    public class ChildrenService : IChildrenService
    {
        private readonly IChildrenRepository _childrenRepository; 
        private readonly IMapper _mapper;
        public ChildrenService(IChildrenRepository childrenRepository, IMapper mapper)
        {
            _childrenRepository = childrenRepository;
            _mapper = mapper;
        }

        public async Task<ChildrenDTO> AddAsync(ChildrenDTO childrenDTO)
        {
            return _mapper.Map<ChildrenDTO>(await _childrenRepository.AddAsync(_mapper.Map<Children>(childrenDTO)));
        }
    }
}
