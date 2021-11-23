using System;
using System.Windows;
using System.Windows.Threading;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            new Presenter(this);
        }

        public event EventHandler timerStart = null;
        public event EventHandler timerReset = null;
        public event EventHandler timerStop = null;

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timerStart.Invoke(sender, e);
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            timerReset.Invoke(sender, e);
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timerStop.Invoke(sender, e);
        }
        private void timer_Tick(object sender, RoutedEventArgs e)
        {
            if (timerBar.Value < 100)
                timerBar.Value++;
        }
        private void InitializeTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timer.IsEnabled = false;
        }
    }
}
