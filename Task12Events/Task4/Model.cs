
namespace Task4
{
    class Model
    {
        public int Add (string x, string y)
        {
            int num1 = int.Parse(x);
            int num2 = int.Parse(y);
            int result = num1 + num2;
            return result;
        }
        public int Sub (string x, string y)
        {
            int num1 = int.Parse(x);
            int num2 = int.Parse(y);
            int result = num1 - num2;
            return result;
        }
        public int Mul(string x, string y)
        {
            int num1 = int.Parse(x);
            int num2 = int.Parse(y);
            int result = num1 * num2;
            return result;
        }
        public double Div(string x, string y)
        {
            double num1 = double.Parse(x);
            double num2 = double.Parse(y);
            double result = num1 / num2;
            return result;
        }
    }

}
