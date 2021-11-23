using System;
namespace Task4
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.actionAdd += new EventHandler(mainWindow_actionAdd);
            view.actionSub += mainWindow_actionSub;
            view.actionMul += mainWindow_actionMul;
            view.actionDiv += mainWindow_actionDiv;
        }
        void mainWindow_actionAdd(object sender, EventArgs e)
        {
            string x = view.number1In.Text;
            string y = view.number2In.Text;
            int result = model.Add(x, y);
            view.resultOut.Text = result.ToString();
        }

        void mainWindow_actionSub(object sender, EventArgs e)
        {
            string x = view.number1In.Text;
            string y = view.number2In.Text;
            int result = model.Sub(x, y);
            view.resultOut.Text = result.ToString();
        }
        void mainWindow_actionMul(object sender, EventArgs e)
        {
            string x = view.number1In.Text;
            string y = view.number2In.Text;
            int result = model.Mul(x, y);
            view.resultOut.Text = result.ToString();
        }
        void mainWindow_actionDiv(object sender, EventArgs e)
        {
            string x = view.number1In.Text;
            string y = view.number2In.Text;
            double result = model.Div(x, y);
            view.resultOut.Text = result.ToString();
        }
    }
}
