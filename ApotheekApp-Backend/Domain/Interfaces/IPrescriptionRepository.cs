using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionRepository
    {
        /// <summary>
        /// Creates a Prescription async without SaveChanges.
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        public Task<Prescription> CreatePrescriptionAsync(Prescription prescription);

        /// <summary>
        /// Saves changes made to the DbSet to the database.
        /// </summary>
        /// <returns></returns>
        public Task SaveChangesAsync();

        /// <summary>
        /// Gets all prescriptions as Queryable, can add link queries and end with .ToListAsync()
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Prescription> GetAll();

        /// <summary>
        /// Get prescription by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Prescription> GetByIdAsync(int id);
    }
}