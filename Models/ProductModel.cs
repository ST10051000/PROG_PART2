using AgriEnergyConnectPlatform.Data;

namespace AgriEnergyConnectPlatform.Models
{
    public class ProductModel
    {
        public int? ProductId { get; set; }
        public int? FarmerId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public DateOnly ProductionDate { get; set; }

        public Farmer Farmer { get; set; }
    }
}
