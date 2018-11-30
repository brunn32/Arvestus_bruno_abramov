using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Bruno_abramov
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int counter = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = "user";
            string password = "SecretPassword";




            if (counter < 3)
            {
                if (userBox.Text == username && passwordBox.Password == password)
                {
                    resultBlock.Text = "Sisenemine õnnestus";
                    this.Frame.Navigate(typeof(Content));
                }

                else
                {
                    resultBlock.Text = "Sisenemine ebaõnnestus";
                    //counter = counter + 1;
                    counter++;
                }
            }
            else
            {
                resultBlock.Text = "Rohkem katseid ei ole";
                button1.IsEnabled = false;
            }

        }
    }
}
