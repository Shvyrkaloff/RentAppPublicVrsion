using System.ComponentModel.DataAnnotations.Schema;

namespace RentApp.Data.Identity
{
    [Table ("Products", Schema= "data")]
    public class Product
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string AppsName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Members { get; set; }
    }
}
