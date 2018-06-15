using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoAppWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<TodoItem> items; 

        public MainWindow()
        {
            InitializeComponent();
            items = new ObservableCollection<TodoItem>
            {
                new TodoItem {Title = "Item1", Details = "Item1 Details"},
                new TodoItem {Title = "Item2", Details = "Item2 Details"},
                new TodoItem {Title = "Item3", Details = "Item3 Details"}
            };
            ItemsListBox.ItemsSource = items;
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new TodoItem {Title = e.ToString(), Details = "AAA"});
        }

        private void ChangeItemButton_Click(object sender, RoutedEventArgs e)
        {
            var firstItem = items.Take(1).SingleOrDefault();
            if (firstItem == null)
            {
                Console.WriteLine("No item found");
                return;
            }

            Console.WriteLine("AAA");
            firstItem.Title = "Modified title";
        }
    }
}