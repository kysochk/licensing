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
    /// Логика взаимодействия для PageCoach.xaml
    /// </summary>
    public partial class PageCoach : Page
    {
        VM vm = new VM();
        List<Coach> coachs = BaseConnect.BaseModel.Coach.ToList();
        public PageCoach()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            CoachList.ItemsSource = coachs;
        }

        private void NewPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenPPC_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Uid);
            PageLoad.MainFrame.Navigate(new PersonalPlayerCard(id));
        }

        

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FiltCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void NewPlayer_Click_1(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new AddCoach());
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeleteCoach_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button IdBtn = (Button)sender;
                int id = Convert.ToInt32(IdBtn.Uid);
                Coach ServicesRemove = BaseConnect.BaseModel.Coach.FirstOrDefault(x => x.Id_Coach == id);
                BaseConnect.BaseModel.Coach.Remove(ServicesRemove);
                coachs.Remove(ServicesRemove);
                BaseConnect.BaseModel.SaveChanges();


                MessageBox.Show("Запись успешно удалена");
                CoachList.Items.Refresh();

            }
            catch
            {

            }
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.GoBack();
        }
    }
}
