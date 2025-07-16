using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Interfaces.CarInterfaces;
using AcunMedyaCarBook.Domain.Entities;
using AcunMedyaCarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaCarBook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GerCarsListWithBrands()
        {
            var values = await _context.Cars
                .Include(c => c.Brand)
                .ToListAsync();
            return values;
        }
    }
}
