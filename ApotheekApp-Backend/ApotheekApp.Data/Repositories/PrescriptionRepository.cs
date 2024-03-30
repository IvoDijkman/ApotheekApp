using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly DataContext _dataContext;

        public PrescriptionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Prescription> CreatePrescriptionAsync(Prescription prescription)
        {
            await _dataContext.AddAsync(prescription);
            await _dataContext.SaveChangesAsync();
            return prescription;
        }

        public async Task<IEnumerable<Prescription>> GetAllAsync() => await _dataContext.Set<Prescription>().ToListAsync();

        public async Task<Prescription> GetById(int id) => await _dataContext.Prescription.FirstOrDefaultAsync(p => p.Id == id);

        public async Task SaveChangesAsync() => await _dataContext.SaveChangesAsync();
    }
}