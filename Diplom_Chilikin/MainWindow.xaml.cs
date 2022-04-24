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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom_Chilikin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BDInf.DB_context context = new DB_context();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AftPeople_Click(object sender, RoutedEventArgs e)
        {
            if (LogText.Text == null && PasswordText.Password == null)
            {
                MessageBox.Show("напишите чего нибудь");

            }
            else
            {
                People people = context.Peoples.Where(x => x.Log == LogText.Text && x.Password == PasswordText.Password).First();
                if (people == null)
                {
                    MessageBox.Show("Не правильный пароль или логин");
                }
                else
                {
                    WPFWin.MainWpf Main = new WPFWin.MainWpf(people);
                    Main.Show();
                    this.Close();
                }
            }

        }

        private void RegistrPeople_Click(object sender, RoutedEventArgs e)
        {
            WPFWin.RegistrPeople registrWpf = new WPFWin.RegistrPeople();
            registrWpf.Show();
            this.Close();
        }
    }
}
