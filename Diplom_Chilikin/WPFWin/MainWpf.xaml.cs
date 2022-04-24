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
    /// Логика взаимодействия для MainWpf.xaml
    /// </summary>
    public partial class MainWpf : Window
    {
        public static BDInf.DB_context context = new DB_context();
        public static People people;
        public MainWpf(People peop)
        {
            InitializeComponent();
            people = peop;
            Addhid(people.IdAccess);
            
        }
        public void Addhid(int i)
        {
            if(i==1)
            {
                AddAuto.Visibility = Visibility.Visible;
                lbServisAuto.ItemsSource = context.Autos.ToList();
            }
            else
            {
                lbServisAuto.ItemsSource = context.Autos.ToList();
            }
            ComboboxFiltr();
        }
        public void ComboboxFiltr()
        {
            foreach(var item in context.Autos)
            {
                StampAuto.Items.Add(item.Stamp);
                EquipmentAuto.Items.Add(item.Equipment);
                EngineAuto.Items.Add(item.Engine);
                ColorAuto.Items.Add(item.Color);
                DriveAuto.Items.Add(item.Drive);
                BoxAuto.Items.Add(item.Box);
            }
        }
        private void ToFind_Click(object sender, RoutedEventArgs e)
        {
            if(SearchText.Text!="")
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Stamp == SearchText.Text).ToList();
            }
            if (ColorAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Color == ColorAuto.SelectedItem.ToString()).ToList();
                ColorAuto.Text = "";
            }
            if (BoxAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Box == BoxAuto.SelectedItem.ToString()).ToList();
                BoxAuto.Text = "";
            }
            if (DriveAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Drive == DriveAuto.SelectedItem.ToString()).ToList();
                DriveAuto.Text = "";
            }
            if (StampAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Stamp == StampAuto.SelectedItem.ToString()).ToList();
                StampAuto.Text = "";
            }
            if (EngineAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Engine == EngineAuto.SelectedItem.ToString()).ToList();
                EngineAuto.Text = "";
            }
            if (EquipmentAuto.SelectedItem != null)
            {
                lbServisAuto.ItemsSource = context.Autos.Where(x => x.Equipment == EquipmentAuto.SelectedItem.ToString()).ToList();
                EquipmentAuto.Text = "";
            }
            //lbServisAuto.ItemsSource = context.Autos.Where(x => x.Stamp == SearchText.Text||x.Color== ColorAuto.SelectedItem.ToString() ||
            //    x.Drive==DriveAuto.SelectedItem.ToString() || x.Box == BoxAuto.SelectedItem.ToString() || x.Engine == EngineAuto.SelectedItem.ToString() || x.Equipment == EquipmentAuto.SelectedItem.ToString()
            //    || x.Stamp== StampAuto.SelectedItem.ToString()).ToList();
        }

        private void AddAuto_Click(object sender, RoutedEventArgs e)
        {
            WPFWin.AddAuto add = new AddAuto(people);
            add.Show();
            this.Close();
        }

        private void Filtr_Click(object sender, RoutedEventArgs e)
        {
            StampAutoTextBlok.Visibility = Visibility.Visible;
            EquipmentAutoTextBlok.Visibility = Visibility.Visible;
            EngineAutoTextBlok.Visibility = Visibility.Visible;
            ColorAutoTextBlok.Visibility = Visibility.Visible;
            DriveAutoTextBlok.Visibility = Visibility.Visible;
            BoxAutoTextBlok.Visibility = Visibility.Visible;

            StampAuto.Visibility = Visibility.Visible;
            EquipmentAuto.Visibility = Visibility.Visible;
            EngineAuto.Visibility = Visibility.Visible;
            ColorAuto.Visibility = Visibility.Visible;
            DriveAuto.Visibility = Visibility.Visible;
            BoxAuto.Visibility = Visibility.Visible;
        }

        private void Bay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Придите в авто-сервис и подипишите заявление");
        }

        private void lbServisAuto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Auto auto = lbServisAuto.SelectedItem as Auto;
            Full_Inf_Auto_Admin_Redakt full_Inf_Auto = new Full_Inf_Auto_Admin_Redakt(auto, people);
            full_Inf_Auto.Show();
            this.Close();
        }
    }
}
