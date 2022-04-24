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
    /// Логика взаимодействия для RegistrPeople.xaml
    /// </summary>
    public partial class RegistrPeople : Window
    {
        public RegistrPeople()
        {
            InitializeComponent();
        }

        private void Bak_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void RegistrAccount_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordText.Text==PorPassword.Text)
            {
                AddPeople(LogText.Text, Mail.Text, Phone.Text, AgeText.Text, PasswordText.Text);
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
        public void AddPeople(string LogText, string Mail,string Phone, string AgeText, string PasswordText)
        {
            BDInf.DB_context context = new BDInf.DB_context();
            context.Peoples.Add(new BDInf.People(2,LogText,Mail,Phone, PasswordText,Convert.ToInt32(AgeText)));
            context.SaveChanges();
        }
    }
}
