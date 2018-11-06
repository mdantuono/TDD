using System;

namespace String.Calculator
{
    public class StringCalculatorService
    {
        public int StringCalculator(string inputString)
        {
            if (inputString == "") return 0;
            int addedValues = 0;
            foreach(var s in inputString.Replace('\n', ',').Split(','))
                addedValues += Int32.Parse(s);
            return addedValues;
        }
    }
}
