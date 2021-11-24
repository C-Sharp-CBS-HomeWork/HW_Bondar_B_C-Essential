using System;
using System.Windows.Threading;

namespace Task3
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;

            view.Timer.Tick += mainWindow_startButton;
            view.timerReset += mainWindow_resetButton;
        }

        void mainWindow_startButton(object sender, EventArgs e)
        {
            view.timerBar.Value = model.DoWork((int)view.timerBar.Value);
            //передаем в DoWork текущее значение timeBar и увеличиваем его пока работает таймер
            //значения тика прописаны в InitTimer() timer.Interval;
            //Timer.Tick срабатывет каждый раз как проходит Интервал;
        }
        void mainWindow_resetButton(object sender, EventArgs e)
        {
            view.timerBar.Value = model.Reset();
            // сбрасывет значение прогресбара в 0;
        }
    }
}
