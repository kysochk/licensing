using Microsoft.Win32;
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
    /// Логика взаимодействия для PagePlayers.xaml
    /// </summary>

    public partial class PagePlayers : Page
    {

        VM vm = new VM();

       
        List<Players> players = BaseConnect.BaseModel.Players.ToList();
       
        List<int> id_play;


        public PagePlayers(int i)
        {
            InitializeComponent();
            load();
           
            id_play = new List<int>();
            FiltCB.ItemsSource = BaseConnect.BaseModel.Region.ToList();
            FiltCB.DisplayMemberPath = "NameRegion";
            FiltCB.SelectedValuePath = "Id_Region";


        }
        public PagePlayers()
        {

            InitializeComponent();
            load();
            id_play = new List<int>();
            FiltCB.ItemsSource = BaseConnect.BaseModel.Region.ToList();
            FiltCB.DisplayMemberPath = "NameRegion";
            FiltCB.SelectedValuePath = "Id_Region";
         



        }

       
        public void load()
        {
            PlayList.ItemsSource = players;
                    }
       
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TypeOfPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


     

        private void PlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FiltCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void NewPlayer_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new AddPlayer());
        }


        
        

        private void FiltCB_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           
            PlayList.ItemsSource = BaseConnect.BaseModel.Players.Where(x => x.Id_Region == (int)FiltCB.SelectedValue).ToList();
        }


        

        private void DeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button IdBtn = (Button)sender;
                int id = Convert.ToInt32(IdBtn.Uid);
                Players ServicesRemove = BaseConnect.BaseModel.Players.FirstOrDefault(x => x.Id_Player == id);
                BaseConnect.BaseModel.Players.Remove(ServicesRemove);
                players.Remove(ServicesRemove);
                BaseConnect.BaseModel.SaveChanges();


                MessageBox.Show("Запись успешно удалена");
                PlayList.Items.Refresh();

            }
            catch
            {
           
            }
        }

        

        private void OpenPPC_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Uid);
            PageLoad.MainFrame.Navigate(new PersonalPlayerCard(id));




            
        }

        private void FiltYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
                       RadioButton RB = (RadioButton)sender;
            switch (RB.Uid)
            {
                case "name":
                    players = players.OrderBy(x => x.Surname).ToList();
                    break;
                case "DR":
                    players = players.OrderBy(x => x.Birthday).ToList();
                    break;
            }
           
            PlayList.ItemsSource = players;

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            PlayList.ItemsSource = BaseConnect.BaseModel.Players.Where(x => x.Name == SearchBar.Text || x.Surname == SearchBar.Text).ToList();
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PageMenu());
        }
    }
}
