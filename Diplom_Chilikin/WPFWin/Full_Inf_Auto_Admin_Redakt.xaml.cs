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
    /// Логика взаимодействия для Full_Inf_Auto_Admin_Redakt.xaml
    /// </summary>
    public partial class Full_Inf_Auto_Admin_Redakt : Window
    {
        BDInf.DB_context context = new DB_context();
        public static People people;
        public static Auto auto;
        public Full_Inf_Auto_Admin_Redakt(Auto at, People peop)
        {
            InitializeComponent();
            people = peop;
            auto = at;
            TextAuto();
        }
        public void TextAuto()
        {
            Image image = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.UriSource = new Uri($@"{auto.Image}");
            image.Source = bi3;
            ImageAuto.Source = image.Source;
            StampText.Text = auto.Stamp;
            EquipmentText.Text = auto.Equipment;
            EngineText.Text = auto.Engine;
            ColorText.Text = auto.Color;
            DriveTxt.Text = auto.Drive;
            BoxText.Text = auto.Box;
            BodyText.Text = auto.Body;
            CostText.Text = auto.Cost.ToString();
            WayText.Text = auto.Image;
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            context.Autos.Remove(auto);
            context.SaveChanges();
            MessageBox.Show("Удаление произошло");
            this.Close();
        }

        private void Redacrt_Click(object sender, RoutedEventArgs e)
        {
            context.Autos.Update(auto);

            context.SaveChanges();
            MessageBox.Show("Редактирование произошло");
        }

        private void Bak_Click(object sender, RoutedEventArgs e)
        {
            MainWpf mainWpf = new MainWpf(people);
            mainWpf.Show();
            this.Close();
        }
    }
}
