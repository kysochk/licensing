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
    /// Логика взаимодействия для AddCoach.xaml
    /// </summary>
    public partial class AddCoach : Page
    {
        public AddCoach()
        {
            InitializeComponent();
            loadT();
        }
        public void loadT()
        {
            List<Coach> vrTC = BaseConnect.BaseModel.Coach.ToList();
           
            vrTC.RemoveAt(0);
          

        }


        private void Team_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.GoBack();
        }

        private void savech_Click(object sender, RoutedEventArgs e)
        {
            int idte = TeamCB.SelectedIndex + 1;
            int idreg = RegCB.SelectedIndex + 1;
            int cit = CitCB.SelectedIndex + 1;
            try
            {
                Coach coaobj = new Coach()
                {
                    Surname = Surname.Text,
                    Name = Name.Text,
                    Patronymic = Patronymic.Text,
                    Bithday = GBBir.DisplayDate,
                    Id_Team = idte,
                    Id_Region = idreg,
                    Id_City = cit

                };
                BaseConnect.BaseModel.Coach.Add(coaobj);
             
                BaseConnect.BaseModel.SaveChanges();

                MessageBox.Show("Данные успешно добавлены");
            }

            catch
            {
                MessageBox.Show("Вы не ввели данные! Заполните все поля/Данные введены неверно");
            }

        }

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Patronymic_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TeamCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void RegCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CitCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
