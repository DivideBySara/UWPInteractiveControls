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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPInteractiveControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Rectangle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Rectangle_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {

        }

        private void TextBlock_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tblock1.Text = "You clicked the button!";
            tbox1.Text = "Text";
            tbox1.SelectedText = "Selected text";
        }
    }
}
