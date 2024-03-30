using ApotheekApp.Domain.Dtos;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Extensions
{
    public static class Mappers
    {
        public static PrescriptionDto MapToPrescriptionDto(this Prescription prescription)
        {
            PrescriptionDto dto = new()
            {
                Id = prescription.Id,
                Name = prescription.Name,
                Description = prescription.Description,
                IssueDate = prescription.IssueDate,
                IsCollected = prescription.IsCollected,
            };
            return dto;
        }
    }
}