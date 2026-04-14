namespace AkilliEvOtomasyonu.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}