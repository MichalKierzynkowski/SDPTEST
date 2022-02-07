using System;

namespace ClassesLibrary
{
    public class Class1
    {
        public int  Number { get; set; }
        public Class1(int number)
        {
            Number = number;
        }

        public bool ReturnCondition()
        {
            if (Number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i * i <= Number; i++)
                {
                    if (Number % i == 0)
                    {
                        return false;
                    }

                   
                }

                return true;

            }

        }

    }
}
