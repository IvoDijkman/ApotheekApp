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
            return prescription;
        }

        public IQueryable<Prescription> GetAll() => _dataContext.Set<Prescription>().AsQueryable();

        public async Task<Prescription> GetByIdAsync(int id) => await _dataContext.Prescription.FirstAsync(p => p.Id == id);

        public async Task SaveChangesAsync() => await _dataContext.SaveChangesAsync();
    }
}