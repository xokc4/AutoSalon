using Diplom_Chilikin.BDInf;
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
using System.Windows.Shapes;

namespace Diplom_Chilikin.WPFWin
{
    /// <summary>
    /// Логика взаимодействия для AddAuto.xaml
    /// </summary>
    public partial class AddAuto : Window
    {
        BDInf.DB_context context = new DB_context();
        public static People people;
        public AddAuto(People pep)
        {
            InitializeComponent();
            people = pep;
        }
        private void Bak_Click(object sender, RoutedEventArgs e)
        {
            MainWpf main = new MainWpf(people);
            main.Show();
            this.Close();
        }

        private void AddAutoBt_Click(object sender, RoutedEventArgs e)
        {
            context.Autos.Add(new Auto(StampText.Text,EquipmentText.Text,EngineText.Text,ColorText.Text,DriveText.Text,BoxText.Text,Convert.ToDouble(CostText.Text),BodyText.Text, WayText.Text));
            context.SaveChanges();
        }
    }
}
