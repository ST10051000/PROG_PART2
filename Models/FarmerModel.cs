using AgriEnergyConnectPlatform.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriEnergyConnectPlatform.Models
{
    public class FarmerModel
    {
        public int? FarmerId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
