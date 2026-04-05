using System;
namespace _10_GenericTypesCollections
{
    public class Library<T> where T : Book
    {
        public string Name { get; set; }
        public List<T> Items { get; set; }

        public Library(string name)
        {
            Name = name;
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            Items.Add(item);
            Console.WriteLine($"Item added to {Name}");
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);
            Console.WriteLine($"Item removed from {Name}");
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

        public int GetCount()
        {
            return Items.Count;
        }

        public T FindItemIndex(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                return Items[index];
            }
            return null;
        }
    }
}


