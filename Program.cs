namespace NarcisNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NarcisNum();
        }

        static void NarcisNum()
        {
            Console.WriteLine("Please Enter the number to check whether the number Narcistic or not");
            string Number = Console.ReadLine();                         //  Getting number from the user.
            string CvToStr;                                             //  Made because the Convert.ToInt32 Method doesn't work correct for chars. 
            int Sum = 0;
            int digitcount = DigitCount(Convert.ToInt32(Number));
            bool CheckNarcis;                                           //  To print the final result for the user.
            for (int i = 0; i < Number.Length; i++)             
            {
                CvToStr = Number[i] + "0";                              //  the string for each letter.
                int EachNum = Convert.ToInt32(CvToStr) / 10;
                Sum = Sum + PowDigitCount(EachNum,digitcount);
            }

            if (Sum == Convert.ToInt32(Number))
            {
               CheckNarcis = true;
            }
            else
            {
                CheckNarcis = false;
            }

            Console.WriteLine(CheckNarcis);
        }
        static int DigitCount(int number)                               // Method which gets the count of digits of the number
        {
            int count = 0;
            while (number > 0) 
            {
                number = number / 10;
                count++;
            }
            return count;
        }
        static int PowDigitCount(int number, int count)          //  The Method to get the ^digitcount of number
        {
            int StartPow = 1;
            for (int i = 1; i<= count; i++)
            {
                StartPow = StartPow * number;
            }
            return StartPow;
        }
    }
}