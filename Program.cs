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
            string Number = Console.ReadLine();                 //  Getting number from the user.
            string CvToStr;                                     //  Made because the Convert.ToInt32 Method doesn't work correct for chars. 
            int Sum = 0;                                        
            bool CheckNarcis;                                   //  To print the final result for the user.
            for (int i = 0; i < Number.Length; i++)             
            {
                CvToStr = Number[i] + "0";                      //  the string for each letter.
                int EachNum = Convert.ToInt32(CvToStr) / 10;
                Sum = Sum + Pow3(EachNum);
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
        static int Pow3(int number)                             //  The Method to get the ^3 of number
        {
            return number * number * number;
        }
    }
}