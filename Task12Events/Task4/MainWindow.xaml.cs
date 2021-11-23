using System;
using System.Windows;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler actionAdd = null;
        public event EventHandler actionSub = null;
        public event EventHandler actionMul = null;
        public event EventHandler actionDiv = null;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            actionAdd.Invoke(sender, e);
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            actionSub.Invoke(sender, e);
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            actionMul.Invoke(sender, e);
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            actionDiv.Invoke(sender, e);
        }
    }
}
