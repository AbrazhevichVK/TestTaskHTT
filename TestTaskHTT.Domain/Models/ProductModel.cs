namespace TestTaskHTT.Domain.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Factory { get; set; }
        public CategoryModel Category { get; set; }
    }
}
