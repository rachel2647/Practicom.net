using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        private readonly IContext _context;
        public ChildrenRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Children> AddAsync(Children children)
        {
            _context.Childrens.Add(children);
            await _context.SaveChangesAsync();
            return children;
        }
    }
}
