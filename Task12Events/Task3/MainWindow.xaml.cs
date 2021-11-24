using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        public DispatcherTimer Timer // свойство поля timer; можно написать автосвойство
        {
            get
            {
                return timer;
            }
        }
        // нужно для получения Value, значения timer в Presentere
        // можно так: public DispatcherTimer Timer => timer; - автосвойство
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            new Presenter(this);
        }

        public event EventHandler timerReset = null;

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = true; // доступ к полю timer за счет его обьявления вначала класса
            //никак не зависит от метода InitializeTimer(); переключает значение заданое в методе
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            timerReset.Invoke(sender, e);
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
            // startButton и здесь событием есть нажатие, больше логики не нужно, вызывать как в reset не нужно
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timer.IsEnabled = false;
        }
    }
}
