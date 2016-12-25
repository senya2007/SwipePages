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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            List<Car> cars = new List<Car>
            {
                new Car() {ModelName = "Toyota Yaris", Miles=100000, Year = 2005 },
                new Car() {ModelName = "Honda Accord", Miles=1300, Year = 2015 },
                new Car() {ModelName = "Nissan Primera", Miles=426000, Year = 1995 }
            };
            DataGrid1.ItemsSource = cars;
        }
    }
}
