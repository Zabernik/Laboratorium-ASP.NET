namespace Laboratorium_2.Models
{
    public class Calculator
    {
        public string op { get; set; }
        public double? dig1 { get; set; }
        public double? dig2 { get; set; }

        public double Calculate()
        {
            double result = 0;
            switch (op)
            {
                case "add":
                    result = (double)(dig1 + dig2);
                    break;
                case "sub":
                    result = (double)(dig1 - dig2);
                    break;
                case "mul":
                    result = (double)(dig1 * dig2);
                    break;
                case "div":
                    result = (double)(dig1 / dig2);
                    break;
            }
            return result;
        }
        public bool IsValid()
        {
            if (op is null || (dig1 == 0 && dig2 == 0))
            {
                return false;
            }
            return true;
        }
    }
}
