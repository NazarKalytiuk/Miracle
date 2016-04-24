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
using Miracle.Views;
using Miracle.Models;
using Miracle.Models.Helpers;
using Miracle.ServiceReference1;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Miracle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Models.Storage.Materials.Add(new Material("matName", (MaterialType)1));
            Models.Storage.Materials[0].Count = 2;
            Employee a = new Employee("nazar", "kalytiuk");
            List<Employee> empl = new List<Employee>() { a };
            Workplace w = new Workplace("wName", 200, empl, new List<Material>() { new Material("matName", (MaterialType)1) }
            , new List<Material>() { new Material("matName2", (MaterialType)1) });
            w.Make();

            //DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Dictionary<Guid, Material>));

            //using (FileStream fs = new FileStream("C:\\MiracleDB\\materials.json", FileMode.OpenOrCreate))
            //{
            //    jsonFormatter.WriteObject(fs, Base<Material>.Items);
            //}

            ServiceClient sc = new ServiceClient();
            var s = Serializer.Serialize(Base<Material>.Items);
            sc.SaveData(s);

            var gg = sc.LoadData(typeof(Material).ToString());
            Base<Material>.Items = Serializer.Deserialize<Material>(gg);
            sc.Close();
        }

        private void About_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new AboutView();
        }

        private void Shipment_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new ShipmentView();
        }

        private void Incoming_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new IncomingView();
        }

        private void Storage_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new StorageView();
        }

        private void Personal_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new PersonalView();
        }

        private void Dashboard_Selected(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new DashboardView();
        }
    }
}
