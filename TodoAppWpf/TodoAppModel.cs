using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using TodoAppWpf.MVVMHelpers;

namespace TodoAppWpf
{
    public class TodoAppModel
    {
        public ObservableCollection<TodoItem> Items { get; }

        public TodoAppModel()
        {
            Items = new ObservableCollection<TodoItem>
            {
             //   new TodoItem {Title = "Item1", Details = "Item1 Details"},
              //  new TodoItem {Title = "Item2", Details = "Item2 Details"},
              //  new TodoItem {Title = "Item3", Details = "Item3 Details"}
            };
        }

        public ICommand AddItemCommand
        {
            get
            {
                return new RelayCommand(param => Items.Add(MakeNewItem()));
            }
        }

        private TodoItem MakeNewItem()
        {
            return new TodoItem
            {
                Title = $"Item {Items.Count + 1}",
                Details = $"Item {Items.Count + 1} Details"
            };
        }

        public ICommand ChangeItemCommand => new RelayCommand(param =>
        {
            var firstItem = Items.Take(1).SingleOrDefault();
            if (firstItem == null)
            {
                Console.WriteLine("No item found");
                return;
            }


            firstItem.Title = "Modified title";
            Console.WriteLine("AAA");
        }, p => Items.Any());
    }
}