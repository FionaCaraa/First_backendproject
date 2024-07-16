namespace First_backend.Models.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
         public string Name { get; set; }
        public string CategoryName { get; set; }
        public float Price { get; set; }
        public Category CategoryId { get; set; }
    }
}
