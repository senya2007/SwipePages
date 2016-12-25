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

namespace SwipePages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>
            {
                new Product() { ModelName = "Bread", UnitCost = 30, Count = 2 },
                new Product() { ModelName = "Milk", UnitCost = 15, Count = 8 },
                new Product() { ModelName = "Water", UnitCost = 18, Count = 9}
            };
            DataGrid1.ItemsSource = products;
        }
    }
}
