namespace Bibikski.ReverseInteger
{
    public class Program
    {
        static void Main()
        {
            int[] tests = new[] { 132, 158, 454, 7868, 10203, 58454, -232, 8548, -2321, -5844 };
            foreach (int test in tests)
                ReverseInt(test);
        }

        static int ReverseInt(int x)
        {
            int returnValue = 0;
            bool isNegative = x < 0;
            string intStr = x.ToString();
            string reversedInt = "";

            for (int i = intStr.Length; i > 0; i--)
                if (intStr[i-1] != '-')
                    reversedInt += intStr[i-1];

            if (isNegative)
                reversedInt = "-" + reversedInt;
            
            int.TryParse(reversedInt, out returnValue);
            return returnValue;
        }
    }
}