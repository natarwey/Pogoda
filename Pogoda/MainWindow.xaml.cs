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
using Pogoda.Data;

namespace Pogoda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Temp> _temps;
        private List<Temp> _listView;
        public MainWindow()
        {
            InitializeComponent();

            _temps = Data.DataContext.Temps;
            _listView = _temps;
        }


        private void DeleteMI_Click(object sender, RoutedEventArgs e)
        {
            Temp selectedMeme = (Temp)LstView.SelectedItem;
            _temps.Remove(selectedMeme);

            LstView.ItemsSource = _temps;
            LstView.Items.Refresh();
        }

        private void ViewMI_Click(object sender, RoutedEventArgs e)
        {
            Temp selectedFilm = (Temp)LstView.SelectedItem;
            MessageBox.Show($"Data: {selectedFilm.Data} \nWeek: {selectedFilm.Week} \nDay of the week: {selectedFilm.Week.Title}", "Soon!");
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            LstView.ItemsSource = _temps;
            LstView.Items.Refresh();
        }
    }
}
