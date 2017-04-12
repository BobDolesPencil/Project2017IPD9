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
using System.Windows.Threading;
using Microsoft.Win32;

namespace ipdMPMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
           
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtPlay_OnClick(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            throw new NotImplementedException();
        }

        private void BtStop_OnClick(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            throw new NotImplementedException();    
        }

        private void BtPause_OnClick(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
            throw new NotImplementedException();
        }

        private void BtPrevious_OnClick(object sender, RoutedEventArgs e)
        {           
            throw new NotImplementedException();
        }

        private void BtNext_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
