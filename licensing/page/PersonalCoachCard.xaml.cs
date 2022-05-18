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
    /// Логика взаимодействия для PersonalCoachCard.xaml
    /// </summary>
    public partial class PersonalCoachCard : Page
    {
        int index = 0;
        public PersonalCoachCard()
        {
            InitializeComponent();
            load();
            List<Coach> coaches = BaseConnect.BaseModel.Coach.ToList();
        }
        public PersonalCoachCard(int i)
        {
            InitializeComponent();
            Coach coach = BaseConnect.BaseModel.Coach.FirstOrDefault(x => x.Id_Coach == i);
            
            DataContext = coach;
            index = i;
        }
        public void load()
        {
            BaseConnect.BaseModel.Coach.ToList();
          


        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.GoBack();
        }
    }
}
