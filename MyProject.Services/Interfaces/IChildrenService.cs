using MyProject.Common.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IChildrenService
    {
        Task<ChildrenDTO> AddAsync(ChildrenDTO childrenDTO);
    }
}
