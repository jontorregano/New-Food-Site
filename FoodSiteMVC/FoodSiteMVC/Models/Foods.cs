namespace FoodSiteMVC.Models
{
    public class Foods
    {
        public int Id { get; set; }
        public string foodName { get; set; }
        public decimal foodPrice { get; set; }
        public byte[] foodImage { get; set; }
    }
}