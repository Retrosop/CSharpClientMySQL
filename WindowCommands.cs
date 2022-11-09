using System.Windows.Input;

namespace myWpf
{
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));

            ComPostav = new RoutedCommand("ComPostav", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }

        public static RoutedCommand ComPostav { get; set; }
    }
}