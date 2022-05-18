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
    /// Логика взаимодействия для PersonalPlayerCard.xaml
    /// </summary>
    public partial class PersonalPlayerCard : Page
    {
        int index = 0;

        
        public PersonalPlayerCard()
        {
            InitializeComponent();
            load();
            List<Players> players = BaseConnect.BaseModel.Players.ToList();
        
        }
        public PersonalPlayerCard(int i)
        {
            InitializeComponent();
            Players players = BaseConnect.BaseModel.Players.FirstOrDefault(x => x.Id_Player == i);
            Licensing lic = BaseConnect.BaseModel.Licensing.FirstOrDefault(x => x.Id_license == i);
            DataContext = players;
            index = i;
        }
        public void load()
        {
            BaseConnect.BaseModel.Players.ToList();
            BaseConnect.BaseModel.Licensing.ToList();


        }
        private void PlayList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void DeletePlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SbrosFilt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewPlayer_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlayList_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void PlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void GameNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TypeAmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TypePut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CoachCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void savech_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addImg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Surname_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

       

        private void DeletePlayer_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click_1(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.GoBack();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Uid);
            PageLoad.MainFrame.Navigate(new AddPlayer(id));
        

        }
    }
}
