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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.GoBack();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User us = new User() { Login = txtLogin.Text, Password = txtPass.Password.GetHashCode(), Id_Role = 2 };
            BaseConnect.BaseModel.User.Add(us);
            BaseConnect.BaseModel.SaveChanges();
            Players pl = new Players() { Surname = txtSureName.Text, Name = txtName.Text, Patronymic = PatronymicTxt.Text, Id_Player = us.Id_User, Birthday = (DateTime)dtDr.SelectedDate };
            BaseConnect.BaseModel.Players.Add(pl);
            BaseConnect.BaseModel.SaveChanges();
            MessageBox.Show("Данные успешно зарегистрированны");
          
        }
    }
}
