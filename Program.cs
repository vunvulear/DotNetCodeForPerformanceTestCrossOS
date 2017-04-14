using System;

namespace TheFightForSurvivingInTheIoTWorld
{
    class Program
    {
        static void Main(string[] args = null)
        {
            if (args.Length < 1)
            {
                CommandNotKnown();
                return;
            }

            //string[] commArgs = new string[2] { "pi", "10000" };
            //string[] commArgs = new string[2] { "pi", "10000" };
            // string[] commArgs = new string[2] { "array", "100000000" };
             //string[] commArgs = new string[1] { "io" };
            //string[] commArgs = new string[1] { "full" };
            string command = commArgs[0];

            switch (command)
            {
                case "pi":
                    CalculatePi(commArgs);
                    break;
                case "array":
                    ArrayPlay(commArgs);
                    break;
                case "io":
                    IOFreak();
                    break;
                case "full":
                    CalculatePi(new string[2] { "pi", "10000" });
                    ArrayPlay(new string[2] { "array", "100000000" });
                    IOFreak();
                    break;
                default:
                    CommandNotKnown();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("-- DONE --");
        }

        private static void IOFreak()
        {
            IOFreak ioFreak = new IOFreak();
            ioFreak.Process();
        }

        private static void ArrayPlay(string[] commArgs)
        {
            int arrayLenght = Convert.ToInt32(commArgs[1]);
            ArrayFreak arrayFreak = new ArrayFreak(arrayLenght);
            arrayFreak.Process();
        }

        private static void CalculatePi(string[] commArgs)
        {
            PiCalculator piCalculator = new PiCalculator();
            int numberOfDigits = Convert.ToInt32(commArgs[1]);
            string pi1000 = piCalculator.Calculate(numberOfDigits);

            Console.WriteLine("Pi:" + pi1000);
        }

        private static void CommandNotKnown()
        {
            Console.WriteLine("Don't know what to do");
        }
    }
}
