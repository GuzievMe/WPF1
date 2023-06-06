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

namespace WpfHomeApp1_Bottonlar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LeftClickOnButton(object sender, EventArgs e)
        {
            
            foreach (var  item in GridMain.Children  )
            {
                if(item is Button btn )
                {
                    if(sender is Button stn)
                    {
                        if (btn.Name == stn.Name )
                        {
                            byte r = (byte)Random.Shared.Next(0, 256);
                            byte g = (byte)Random.Shared.Next(0, 256);
                            byte b = (byte)Random.Shared.Next(0, 256);
                            Color newColor = Color.FromRgb(r, g, b);

                            btn.Background = new SolidColorBrush(newColor);
                            MessageBox.Show(btn.Content.ToString(), " Information");
                        }
                    }
                }
            }
        }

        private void RightClickOnButton(object sender, MouseButtonEventArgs e)
        {
            foreach (var item in GridMain.Children)
            {
                if (item is Button btn)
                {
                    if (sender is Button stn)
                    {
                        if (btn.Name == stn.Name)
                        {   
                            windw.Title = btn.Content.ToString();
                            btn.Visibility = Visibility.Hidden;
                        }
                    }
                }
            }
        } 
    }
}
