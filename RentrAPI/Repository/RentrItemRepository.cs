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

            List<RentrItem>? item = new List<RentrItem>(_item);
            if (Name != null)
            {
                item = item.FindAll(items => items.Name != null && items.Name.StartsWith(Name));
            }

            return item;
            
        }
        public RentrItem? GetById(int id)
        {
            RentrItem? item = _item!.Find(item => item.Id == id);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public RentrItem Add(RentrItem newItem)
        {

            newItem.Id = _NextId++;
            _item!.Add(newItem);
            return newItem;
        }
    }
}
