using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class MedicineRepository(DataContext context) : IMedicineRepository  //check if this works with medicine instead of the medicines list
    {
        public async Task Delete(int id)
        {
            Medicine? medicine = await context.Medicine.FirstOrDefaultAsync(m => m.Id == id);

            if (medicine != null)
            {
                context.Medicine.Remove(medicine);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            return await context.Medicine.ToListAsync();
        }

        /* public async Task<IEnumerable<Medicine>?> GetAllByClientAsync(Client client)
         {
             return (IEnumerable<Medicine>?)client.Medicine;
         }*/

        public async Task<Medicine?> GetByIdAsync(int id)
        {
            return await context.Medicine.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}