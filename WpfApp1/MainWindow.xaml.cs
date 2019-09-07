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
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        string day="day";

        private void lbl1_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }
   
        void Clock()
        {
            Thread.Sleep(1000);
            lbl1.Content = DateTime.Now.ToString();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = new Thread(Clock);
            t.Start();
            //lbl1.Content = "Abc";
            lbl1.Content = day;
        }
        /*
private void Button_Click(object sender, RoutedEventArgs e)
{


   //for (int i=1;i<5;i++)
   //{
   //    //Thread.Sleep(100);
   //    Task.Delay(2000).ContinueWith(_ =>
   //    {
   //        //MessageBox.Show("a");
   //        var d = DateTime.Now;
   //        var s = d.ToLongTimeString();
   //        lbl1.Content = s;
   //    });

   //}

}
*/
    }
}
