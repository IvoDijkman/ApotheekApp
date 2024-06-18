using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionService
    {
        /// <summary>
        /// Creates a prescription DbSet. SaveChanges has to be called in the repository for it to be saved to the database.
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        Task<Prescription> CreateAsync(Prescription prescription);

        /// <summary>
        /// Gets all prescriptions.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Prescription>> GetAll();

        /// <summary>
        /// Gets all Open prescriptions: All presciptions where IsCollected is set to false.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Prescription>> GetAllOpenPrescriptions();

        /// <summary>
        /// Gets prescription by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Prescription> GetByIdAsync(int id);

        /// <summary>
        /// Toggles IsCollected property of the prescription. This is set to true when the presciption has been collected by the customer/client.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> ToggleIsCollectedAsync(int id);
    }
}