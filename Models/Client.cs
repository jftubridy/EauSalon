namespace ClientCatalog.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Rating { get; set; }
        public int StylistId { get; set; }
        public virtual Stylist Stylist { get; set; }
    }

}
