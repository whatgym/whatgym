using Domain;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository
{
    public class BooRepository
    {
        private readonly FooContext _context;
        private readonly DbSet<Boo> _dbSet;
        public BooRepository(FooContext context)
        {
            _context = context;
            _dbSet = _context.Set<Boo>();
        }
    }
}
