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

namespace licensing
{
    /// <summary>
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Page
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AvtorizBtn_Click(object sender, RoutedEventArgs e)
        {
            int pass = PasswordTxt.Password.GetHashCode();
            User UserOb = BaseConnect.BaseModel.User.FirstOrDefault(u => u.Login == logtxt.Text && u.Password == pass);
            if (UserOb==null)
            {
                MessageBox.Show("Данные введены не верно");
            }
            else
            { 
            switch (UserOb.Id_Role)
            {
                case 1:
                    MessageBox.Show("Вы вошли как администратор");
                        PageLoad.MainFrame.Navigate(new PageMenu());
                    break;
                default:
                    MessageBox.Show("Вы вышли как тренер. Обратите внимание, ваш функционал ограничен");
                        PageLoad.MainFrame.Navigate(new PagePlayers());
                        break;
            }
            }
        }

        private void RegisBtn_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PageReg());
        }
    }
}
