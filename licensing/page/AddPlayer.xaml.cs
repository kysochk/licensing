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
using System.Drawing;

namespace licensing
{
    /// <summary>
    /// Логика взаимодействия для AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Page
    {
        string img = "\\null\\null";
        int ident = -1;


        public AddPlayer(int id)
        {
            InitializeComponent();
            loadT();


            Players play = BaseConnect.BaseModel.Players.FirstOrDefault(x => x.Id_Player == id);
          int k = (int)play.Id_License;
          
          Licensing lic = BaseConnect.BaseModel.Licensing.FirstOrDefault(x => x.Id_license == k);
       
            TypeAmp.SelectedIndex = Convert.ToInt32(play.Id_Amplua - 1);
            TypePut.SelectedIndex = Convert.ToInt32(play.Id_Putter - 1);
            CoachCB.SelectedIndex = Convert.ToInt32(play.Id_Coach - 1);
            TeamCB.SelectedIndex = Convert.ToInt32(play.Id_Team - 1);
            RegCB.SelectedIndex = Convert.ToInt32(play.Id_Region - 1);
            TypeLic.SelectedIndex = Convert.ToInt32(play.Id_TypeLicense - 1);
            NumberLicenseTB.Text = lic.NumberLicense;
            GBBir.DisplayDate = play.Birthday;
           GBStart.DisplayDate = (DateTime)lic.StartLicense;
           GBEnd.DisplayDate = (DateTime)lic.EndLicense;
            CitCB.SelectedIndex = Convert.ToInt32(play.Id_City - 1);
            Surname.Text = play.Surname;



        

            DataContext = play;
           // DataContext = lic;

            ident = id;
            addImg.Content = "Обновить изображение";
            savech.Content = "Обновить данные";

            img = play.Image;
        }


        public AddPlayer()
        {

            InitializeComponent();
            loadT();


        }
        public void loadT()
        {
            List<Players> vrTP = BaseConnect.BaseModel.Players.ToList();
            List<Licensing> vrTL = BaseConnect.BaseModel.Licensing.ToList();
            vrTP.RemoveAt(0);
            vrTL.RemoveAt(0);

        }


        private void ArticylTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NamePtB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TypeP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Kol_voChel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Number_cex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Mincost_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Descr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void savech_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addImg_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".jpg"; // задаем расширение по умолчанию
            openFileDialog.Filter = "Изображения |*.jpg;*.png"; // задаем фильтр на форматы файлов
            var result = openFileDialog.ShowDialog();

            if (result == true)//если файл выбран
            {

                img = openFileDialog.FileName;
                imgh.Source = BitmapFrame.Create(new Uri(img));

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PagePlayers());
        }

        private void savech_Click_1(object sender, RoutedEventArgs e)
        {
            int idapm = TypeAmp.SelectedIndex + 1;
            int idput = TypePut.SelectedIndex + 1;
            int idco = CoachCB.SelectedIndex + 1;
            int idte = TeamCB.SelectedIndex + 1;
            int idreg = RegCB.SelectedIndex + 1;
            int idtyplic = TypeLic.SelectedIndex + 1;
            int cit = CitCB.SelectedIndex + 1;
          

            try
            {

                Players playersob = new Players()
                {

                    Image = img,
                    Surname = Surname.Text,
                    Name = Name.Text,
                    Patronymic = Patronymic.Text,
                    Birthday = GBBir.DisplayDate,
                    Id_Amplua = idapm,
                    GameNumber = Convert.ToInt32(GameNumber.Text),
                    Id_Putter = idput,
                    Id_Coach = idco,
                    Id_Team = idte,
                    Id_Region = idreg,
                    Id_TypeLicense = idtyplic,
                    Id_City = cit
                    


                };
                Licensing licob = new Licensing()
                {
         
                    NumberLicense = NumberLicenseTB.Text,
                    StartLicense = GBStart.DisplayDate,
                    EndLicense = GBEnd.DisplayDate,
                    Id_TypeLicense = idtyplic
                };
                BaseConnect.BaseModel.Players.Add(playersob);
                BaseConnect.BaseModel.Licensing.Add(licob);
                BaseConnect.BaseModel.SaveChanges();

                MessageBox.Show("Данные успешно добавлены");


            }
            catch
            {
                MessageBox.Show("Вы не ввели данные! Заполните все поля/Данные введены неверно");
            }
        }


        private void TypeAmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GameNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TypePut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SurnameCo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameCo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PatronymicCo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Team_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CoachCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CoachCB_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TeamCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RegCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TypeLic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}








