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
         
            if (IdSelected != 0)
                {
                    Tovar t = db.tovar
            .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
            .FirstOrDefault();

                    InputName.Text = t.Name;
                    InputEdizm.Text = t.Edizm;
                    InputCena.Text = Convert.ToString(t.Cena);
                }
            }
        }

        private void AddTovar(object sender, RoutedEventArgs e)
        {

            using (var db = new DataContext())
            {
                    var g = new Tovar();

                    g.Name = InputName.Text;
                    g.Edizm = InputEdizm.Text;

                    try
                    {
                        g.Cena = int.Parse(InputCena.Text);
                        
                        db.tovar.Add(g);
                        db.SaveChanges();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("{0}: Неправильно ввели число", InputCena.Text);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("{0}: Перевышение типа данных", InputCena.Text);
                    }
       

                    tovars.Clear();
                    var glist = db.tovar.ToList();
                    foreach (Tovar g1 in glist)
                    {
                        tovars.Add(g1);
                    }
                    tovarList.ItemsSource = tovars;


            }
        }

        private void MouseClick(object sender, RoutedEventArgs e){

            IdSelected= tovarList.SelectedIndex;
                  
            using (var db = new DataContext())
            {
                if (IdSelected != 0)
                {
                    Tovar t = db.tovar
                      .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                      .FirstOrDefault();

                    InputName.Text = t.Name;
                    InputEdizm.Text = t.Edizm;
                    InputCena.Text = Convert.ToString(t.Cena);
                }

               

                //Tovar t = db.tovar
                // .Where(c => c.IdTovar == int.Parse("" + tovarList.SelectedItems[0]))
                // .FirstOrDefault();

                //InputName.Text = t.Name;
                //InputEdizm.Text = t.Edizm;
                //InputCena.Text = Convert.ToString(t.Cena);
            }

            


        }

        private void DeleteTovar(object sender, RoutedEventArgs e)
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

        private void UpdateTovar(object sender, RoutedEventArgs e)
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

                    try
                    {
                        t.Cena = int.Parse(InputCena.Text);
                        db.SaveChanges();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("{0}: Неправильно ввели число", InputCena.Text);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("{0}: Перевышение типа данных", InputCena.Text);
                    }



                   

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

        private void FirstTovar(object sender, RoutedEventArgs e)
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

        private void EndTovar(object sender, RoutedEventArgs e)
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

        private void DownTovar(object sender, RoutedEventArgs e)
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

        private void UpTovar(object sender, RoutedEventArgs e)
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
