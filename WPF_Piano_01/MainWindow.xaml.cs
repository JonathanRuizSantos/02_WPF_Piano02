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

namespace WPF_Piano_01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double f;
        double potencia;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTC_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota= new System.Media.SoundPlayer();
            nota.SoundLocation = @"48.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 1;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2,potencia);
            LB1.Items.Add(f);
        }

        private void BTDb_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"49.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 2;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTD_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"50.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 3;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTEb_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"51.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 4;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTE_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"52.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 5;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTF_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"53.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 6;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTGb_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"54.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 7;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTG_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"55.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 8;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTAb_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"56.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 9;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTA_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"57.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 10;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTBb_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"58.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 11;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }

        private void BTB_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer nota = new System.Media.SoundPlayer();
            nota.SoundLocation = @"59.wav";
            nota.Load();
            nota.Play();
            double teta = 4;
            double n = 12;
            potencia = (teta - 3) + ((n - 10) / 12);
            f = 440 * Math.Pow(2, potencia);
            LB1.Items.Add(f);
        }
    }
}
