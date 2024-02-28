namespace ApotheekApp.Domain.Models
{
    public class ClientMedicine
    {
        public string ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}