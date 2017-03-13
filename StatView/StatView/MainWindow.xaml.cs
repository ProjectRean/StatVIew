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

namespace StatView
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean usingDefaultAPI;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Execute_Button_Click(object sender, RoutedEventArgs e)
        {
            if (usingDefaultAPI)
            {
                Information.Player player = new Information.Player();
            }
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_UsingAPI(object sender, RoutedEventArgs e)
        {
            this.usingDefaultAPI = true;
        }

        private void CheckBox_unusedAPI(object sender, RoutedEventArgs e)
        {
            this.usingDefaultAPI = false;
        }
    }
}

namespace Information
{
    public class Player
    {
        public Player()
        {

        }

        public Player(String name)
        {

        }
        public String name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
