using System;
using System.Windows;
using System.Windows.Input;

namespace beak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HotKey hotKey;

        public MainWindow()
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
            
        }
    }
}
