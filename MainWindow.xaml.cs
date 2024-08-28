using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace lab_mdk_7
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
        Queue<string> q1= new Queue<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {if (tbElementQueue != null)
            {
                q1.Enqueue(tbElementQueue.Text);
                lbQueue.Items.Add(tbElementQueue.Text);
                tbElementQueue.Text = "";
            }
            else MessageBox.Show("елемента нет)");
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { string a= q1.Dequeue();
            lbQueue.Items.Remove(a);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int legth=0;
            foreach (var item in q1) 
            {
               legth+= item.Length;

            }
            tbResultQueue.Text = legth.ToString();
        }
    }
}