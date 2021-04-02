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

namespace TFCHMI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeSpan timespan = TimeSpan.MinValue;
        private bool isPause = false;
        private bool isPlay = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonRunAway_Click(object sender, RoutedEventArgs e)
        {
           // media.Source = new Uri("Media\\Gandalf.mp4", UriKind.Relative);
            media.Position = TimeSpan.Zero;
            if (media.Source != null)
            {
                media.Play();
                isPlay = true;
            }
            else
            {
                throw new Exception("Видео не найдено");
            }
        }
        private void ButtonShrek_Click(object sender, RoutedEventArgs e)
        {
           //  media.Source = new Uri("Media\\Shrek.mp4", UriKind.Relative);
            media.Position = TimeSpan.Zero;
            if (media.Source != null)
            {
                media.Play();
                isPlay = true;
            }
            else
            {
                throw new Exception("Видео не найдено");
            }
        }
        private void ButtonVolk_Click(object sender, RoutedEventArgs e)
        {
          // media.Source = new Uri("Media\\Volk.MP4", UriKind.Relative);
            media.Position = TimeSpan.Zero;
            if (media.Source != null)
            {
                media.Play();
                isPlay = true;
            }
            else
            {
                throw new Exception("Видео не найдено");
            }
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            media.Close();
            media.Source = null;
            timespan = TimeSpan.MinValue;
            isPlay = false;
        }
        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            if (media.Source != null && !isPause)
            {
                isPause = true;
                isPlay = false;
                timespan = media.Position;
                media.Stop();
            }

        }
        private void butPlay_Click(object sender, RoutedEventArgs e)
        {
            if (media.Source != null && !isPlay)
            {
                if(timespan != TimeSpan.MinValue)
                {
                    media.Position = timespan;
                }
                isPlay = true;
                isPause = false;
                media.Play();
            }
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media != null && media.Source != null)
            {
                media.Volume = e.NewValue / 100;
            }
        }
    }
}
