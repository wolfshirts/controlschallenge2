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

namespace controlschallenge2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random random = new Random();
        int leftOrRightAligned = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            string[] myTexts = { "Wow, it worked.", "Amazing changes happening here!", "Look out we got a clicker!" };

            

            if (myCheckBox.IsChecked == true)
            {
                myTextBlock.Text = myTexts[random.Next(0, myTexts.Length)];
                if(leftOrRightAligned == 1)
                {
                    myTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    leftOrRightAligned = 0;
                }
                else
                {
                    myTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                    leftOrRightAligned = 1;
                }
            }
            else
            {
                myTextBlock.Text = "Text changing is currently disabled.";
                myTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
