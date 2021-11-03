using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Dictionary
    {
        private string[] rus = new string[5];
        private string[] ukr = new string[5];
        private string[] eng = new string[5];
        public Dictionary()
        {
            rus[0] = "дом"; ukr[0] = "будинок"; eng[0] = "house";
            rus[1] = "клубника"; ukr[1] = "полуниця"; eng[1] = "strawberry";
            rus[2] = "машина"; ukr[2] = "авто"; eng[2] = "car";
            rus[3] = "улица"; ukr[3] = "вулиця"; eng[3] = "street";
            rus[4] = "почта"; ukr[4] = "пошта"; eng[4] = "mail";
        }

        public string this [string index]
        {
            get
            {
                for (int i = 0; i < rus.Length; i++)
                    if (rus[i] == index)
                        return rus[i] + " - " + ukr[i] + " - " + eng[i];
                    else if (ukr[i] == index)
                        return ukr[i] + " - " + rus[i] + " - " + eng[i];
                    else if (eng[i] == index)
                        return eng[i] + " - " + rus[i] + " - " + ukr[i];
                return string.Format($"{index} - нет перевода для этого слова");

            }
        }

        public string this [int index]
        {
            get
            {
                if (index >= 0 && index < rus.Length)
                    return rus[index] + " - " + ukr[index] + " - " + eng[index];
                else
                    return "Попытка обращения за пределы массива!";
            }
        }
    }
}
