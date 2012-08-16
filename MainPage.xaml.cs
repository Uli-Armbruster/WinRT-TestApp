using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Timings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Bootstrapping(15001); //use 15001 if you want to test an invalid startup
        }

        private void Bootstrapping(int sleepTime)
        {
            Debug.WriteLine(string.Format("{0}: Bootstrapping started", DateTime.Now));
            MyThreadingHelpers.Sleep(sleepTime);
            Debug.WriteLine(string.Format("{0}: Bootstrapping finished", DateTime.Now));

            Output.Text = "App started";
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void DoSomething_Click(object sender, RoutedEventArgs e)
        {
            MyThreadingHelpers.Sleep(1000);
            Output.Text = "Aktion ausgeführt";
        }
    }
}