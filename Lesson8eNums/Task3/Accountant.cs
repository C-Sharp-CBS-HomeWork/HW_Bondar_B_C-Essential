using System;

namespace Task3
{
    class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            int requirements = (int)worker;
            if (hours >= requirements)
                return true;
            else
                return false;
        }
    }
}
