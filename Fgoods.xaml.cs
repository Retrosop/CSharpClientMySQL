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
using System.Windows.Shapes;

namespace myWpf
{
    /// <summary>
    /// Interaction logic for Fgoods.xaml
    /// </summary>
    public partial class Fgoods : Window
    {
        public Fgoods()
        {
            InitializeComponent();

            //List<Goods> n = new List<Goods>();
            //using (var db = new DataContext())
            //{

            //    var glist = db.goods2.ToList();
            //    foreach (Goods g in glist)
            //    {
            //        n.Add(g);
            //    }
            //}
            //List<Goods> n = new List<Goods>()
           // {
          //      new Goods(){Id=123,Name="Утюг",Cena=100},
         //       new Goods(){Id=124,Name="ТВ",Cena=105}
          //  };

            //goodsList.ItemsSource = n;



        }

        void PrintText(object sender, SelectionChangedEventArgs args)
        {
              ListView lbi = ((sender as ListView).SelectedItem as ListView);
       //     tb.Text = "   You selected " + lbi.Content.ToString() + ".";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //using (var db = new DataContext())
            //{

            //    Goods g = new Goods
            //    {
            //        Name = InputName.Text

            //    };

            //    db.goods2.Add(g);
            //    db.SaveChanges();
            //}
        }
    }

}
