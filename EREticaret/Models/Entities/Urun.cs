namespace EREticaret.Models.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Stock { get; set; }

    }
}
