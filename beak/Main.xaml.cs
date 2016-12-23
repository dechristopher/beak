using System;
using System.Windows;
using System.Windows.Input;

namespace beak
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        HotKey hotKey;

        public Main()
        {
            InitializeComponent();
            Console.WriteLine("It works!");

            hotKey = new HotKey(Key.R, KeyModifier.Alt, OnHotKeyHandler);
        }

        private void OnHotKeyHandler(HotKey hotKey)
        {
            Console.WriteLine("READY!");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            hotKey.Unregister();
        }
    }
}
