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
        /// Gets all prescriptions.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Prescription>> GetAllAsync();

        /// <summary>
        /// Get prescription by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Prescription> GetById(int id);
    }
}