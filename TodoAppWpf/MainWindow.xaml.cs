using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            var items = new List<TodoItem>
            {
                new TodoItem {Title = "Item1", Details = "Item1 Details"},
                new TodoItem {Title = "Item2", Details = "Item2 Details"},
                new TodoItem {Title = "Item3", Details = "Item3 Details"}
            };
            ItemsListBox.ItemsSource = items;
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("AAA");
        }
    }
}