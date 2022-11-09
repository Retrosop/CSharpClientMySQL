using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TovarForm.xaml
    /// </summary>
    public partial class TovarForm : Window
    {
        int IdSelected=0;

        ObservableCollection<Tovar> tovars;
        public TovarForm()
        {
            InitializeComponent();

            tovars = new ObservableCollection<Tovar>();
            using (var db = new DataContext())
            {

                var glist = db.tovar.ToList();
                foreach (Tovar g in glist)
                {
                    tovars.Add(g);
                }
          
            tovarList.ItemsSource = tovars;

            tovarList.SelectedIndex = IdSelected;

            Tovar t = db.tovar
                .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                .FirstOrDefault();

            InputName.Text = t.Name;
            InputEdizm.Text = t.Edizm;
            InputCena.Text = Convert.ToString(t.Cena);
         }
        }

        private void AddTovar(object sender, RoutedEventArgs e)
        {

            using (var db = new DataContext())
            {
                    var g = new Tovar();

                    g.Name = InputName.Text;
                    g.Edizm = InputEdizm.Text;
                    g.Cena = int.Parse(InputCena.Text);

                    db.tovar.Add(g);
                    db.SaveChanges();

                tovars.Clear();
                var glist = db.tovar.ToList();
                foreach (Tovar g1 in glist)
                {
                    tovars.Add(g1);
                }
                tovarList.ItemsSource = tovars;


          //  MessageBox.Show("Товар успешно добавлен");

            }
        }

        private void MouseClick(object sender, RoutedEventArgs e){
        
            using (var db = new DataContext())
            {
                Tovar t = db.tovar
                  .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                  .FirstOrDefault();

                InputName.Text = t.Name;
                InputEdizm.Text = t.Edizm;
                InputCena.Text = Convert.ToString(t.Cena);


                //tovarList.SelectedIndex = IdSelected;

                //Tovar t = db.tovar
                // .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                // .FirstOrDefault();

                //InputName.Text = t.Name;
                //InputEdizm.Text = t.Edizm;
                //InputCena.Text = Convert.ToString(t.Cena);
            }

            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          


            if (tovarList.SelectedIndex == -1) MessageBox.Show("Выделите запись");
            else
            { 
                MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись", "Удаление", MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    using (var db = new DataContext())
                    {

                        Tovar t = db.tovar
                            .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                            .FirstOrDefault();

                        db.tovar.Remove(t);
                        db.SaveChanges();

                        tovars.Clear();
                        var glist = db.tovar.ToList();
                        foreach (Tovar g1 in glist)
                        {
                            tovars.Add(g1);
                        }
                        tovarList.ItemsSource = tovars;


                    }
                }

            }






        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tovarList.SelectedIndex == -1) MessageBox.Show("Выделите запись");
            else
            {

                using (var db = new DataContext())
                {

                    Tovar t = db.tovar
                        .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                        .FirstOrDefault();

                    t.Name = InputName.Text;
                    t.Edizm = InputEdizm.Text;
                    t.Cena = int.Parse(InputCena.Text);

                    db.SaveChanges();

                    tovars.Clear();
                    var glist = db.tovar.ToList();
                    foreach (Tovar g1 in glist)
                    {
                        tovars.Add(g1);
                    }
                    tovarList.ItemsSource = tovars;


                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var db = new DataContext())
            {
                tovars.Clear();
                var glist = db.tovar.ToList();
                foreach (Tovar g1 in glist)
                {
                    tovars.Add(g1);
                }
                tovarList.ItemsSource = tovars;

                IdSelected = 0;

                tovarList.SelectedIndex = IdSelected;

                Tovar t = db.tovar
                 .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                 .FirstOrDefault();

                InputName.Text = t.Name;
                InputEdizm.Text = t.Edizm;
                InputCena.Text = Convert.ToString(t.Cena);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (var db = new DataContext())
            {
                tovars.Clear();
                var glist = db.tovar.ToList();
                foreach (Tovar g1 in glist)
                {
                    tovars.Add(g1);
                }

                IdSelected = tovars.Count - 1;

                tovarList.SelectedIndex = IdSelected;
           
               
                 Tovar t = db.tovar
                  .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                  .FirstOrDefault();

                    InputName.Text = t.Name;
                    InputEdizm.Text = t.Edizm;
                    InputCena.Text = Convert.ToString(t.Cena);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (var db = new DataContext())
            {
                tovars.Clear();
                var glist = db.tovar.ToList();
                foreach (Tovar g1 in glist)
                {
                    tovars.Add(g1);
                }
                tovarList.ItemsSource = tovars;

                if (IdSelected == tovars.Count - 1) IdSelected = tovars.Count - 1;
                else
                    IdSelected = IdSelected + 1;

                tovarList.SelectedIndex = IdSelected;
                
             
                Tovar t = db.tovar
                 .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                 .FirstOrDefault();

                InputName.Text = t.Name;
                InputEdizm.Text = t.Edizm;
                InputCena.Text = Convert.ToString(t.Cena);

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            using (var db = new DataContext())
            {
                tovars.Clear();
                var glist = db.tovar.ToList();
                foreach (Tovar g1 in glist)
                {
                    tovars.Add(g1);
                }
                tovarList.ItemsSource = tovars;

                if (IdSelected == 0) IdSelected = 0;
                else
                    IdSelected = IdSelected - 1;



                tovarList.SelectedIndex = IdSelected;


                Tovar t = db.tovar
                 .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                 .FirstOrDefault();

                InputName.Text = t.Name;
                InputEdizm.Text = t.Edizm;
                InputCena.Text = Convert.ToString(t.Cena);

            }
        }
    }
}
