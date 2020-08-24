namespace ANTIQUEStore.Domain.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Year { get; set; }
        public bool IsDeleted { get; set; }
    }
}
