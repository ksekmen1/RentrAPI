using RentrAPI.Models;
namespace RentrAPI.Repository
{
    public class RentrItemRepository
    {
        public int _NextId;
        private List<RentrItem> _item;

        public RentrItemRepository()
        {
            _NextId = 1;
            _item = new List<RentrItem>
            {
                new RentrItem(){Id = _NextId++, Name="Hoejtaler", Price = 50, Quantity = 3},
                new RentrItem(){Id = _NextId++, Name="Cykel", Price = 30, Quantity = 1},
                new RentrItem(){Id = _NextId++, Name="Borremaskine", Price = 25, Quantity = 2},
                new RentrItem(){Id = _NextId++, Name="Wok", Price = 25, Quantity = 3},

            };
        }
        public List<RentrItem>? GetAll(string? Name = null)
        {

            List<RentrItem>? items = new List<RentrItem>(_item);
            if (Name != null)
            {
                items = items.FindAll(item => item.Name != null && item.Name.StartsWith(Name));
            }

            return items;
            
        }
    }
}
