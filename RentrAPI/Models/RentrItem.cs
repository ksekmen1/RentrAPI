namespace RentrAPI.Models
{
    public class RentrItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Quantity}";
        }

    }
}
