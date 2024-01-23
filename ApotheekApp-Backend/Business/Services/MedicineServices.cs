using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Business.Services
{
    public class MedicineServices : IMedicineServices
    {
        public IEnumerable<Medicine> GetAllAsync()
        {
            // Return all medicine
            throw new NotImplementedException();
        }
        public IEnumerable<Medicine> GetAllByUserAsync() // Appuser user (pass as parameter)
        {
            // Return all medicine of a specific user based on id
            throw new NotImplementedException();
        }

        public Medicine GetByIdAsync(int id)
        {
            // Return medicine by id
            throw new NotImplementedException();
        }

        public Task Delete(int id) // Appuser user (pass as parameter)
        {
            // Delete medicine of a specific user based on id
            throw new NotImplementedException();
        }
    }
}
