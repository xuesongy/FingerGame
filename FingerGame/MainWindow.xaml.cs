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

namespace FingerGame {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void PanDings(string userFist) {
            Player p1 = new Player();
            int pFist = p1.showFist(userFist);

            Computer c1 = new Computer();
            int cFist = c1.showFist();

            lblComputer.Content = c1.FistName;
            lblUser.Content = p1.FistName;

            UserState result = CaiPan.CaiDing(pFist, cFist);
            switch (result) {
                case UserState.PingShou: lblResult.Content = "平手"; break;
                case UserState.PlayerWin: lblResult.Content = "玩家赢"; break;
                case UserState.PlayerLose: lblResult.Content = "电脑赢"; break;
            }
        }
        private void btnStone_Click(object sender, RoutedEventArgs e) {
            PanDings("石头");
        }

        private void btnJianDao_Click(object sender, RoutedEventArgs e) {
            PanDings("剪刀");
        }

        private void btnBu_Click(object sender, RoutedEventArgs e) {
            PanDings("布");
        }
    }
}
