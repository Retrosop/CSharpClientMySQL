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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace myWpf
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

        private void ComPostav_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PostavForm form = new PostavForm();
            form.Show();
        }

            private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }

        private void TovarClick(object sender, RoutedEventArgs e)
        {
            TovarForm form = new TovarForm();
            form.Show();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            TovarForm form = new TovarForm();
            form.Show();
        }


        //private void PostavClick(object sender, RoutedEventArgs e)
        //{
        //    Fgoods fg = new Fgoods();
        //    fg.Show();
        //}
        //private void PrihodClick(object sender, RoutedEventArgs e)
        //{
        //    Fgoods fg = new Fgoods();
        //    fg.Show();

        //}
        //private void QueryClick(object sender, RoutedEventArgs e)
        //{
        //    Fgoods fg = new Fgoods();
        //    fg.Show();
        //}
        //private void SysClick(object sender, RoutedEventArgs e)
        //{
        //    Fgoods fg = new Fgoods();
        //    fg.Sh
        //         private void TovarClick(object sender, RoutedEventArgs e)
        //    {
        //        Fgoods fg = new Fgoods();
        //        fg.Show();
        //    }
        //}
        //private void AboutClick(object sender, RoutedEventArgs e)
        //{
        //    Fgoods fg = new Fgoods();
        //    fg.Show();
        //}
    }
}
