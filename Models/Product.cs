namespace NetApp.Models
{
    public class Product
    {
        public required int Id {get;set;}
        public required string Name {get;set;}
        public required double Price {get;set;}
        public required string Description {get;set; }
    }
}