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
            view.timerStart += new EventHandler(mainWindow_startButton);
            view.timerReset +=
            view.timerStop +=
        }

        void mainWindow_startButton(object sender, EventArgs e)
        {
        }
    }
}
