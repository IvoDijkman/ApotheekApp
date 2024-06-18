using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ApotheekApp.Data.Repositories
{
    [ExcludeFromCodeCoverage]
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

        public IEnumerable<Prescription> GetAll() => _dataContext.Set<Prescription>().AsQueryable();

        public async Task<Prescription> GetByIdAsync(int id) => await _dataContext.Prescription.FirstAsync(p => p.Id == id);

        public async Task SaveChangesAsync() => await _dataContext.SaveChangesAsync();
    }
}