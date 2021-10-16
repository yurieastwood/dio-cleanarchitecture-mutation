namespace DIO.Mutation.Domain
{
    public class CoupleOfNumbers
    {
        private readonly int _number1;
        private readonly int _number2;

        private const string Negative = "NEGATIVE";
        private const string Positive = "POSITIVE";
        private const string Odd = "ODD";
        private const string Even = "EVEN";

        public CoupleOfNumbers(int number1, int number2) =>
            (_number1, _number2) = (number1, number2);

        public string GetSumValueDetails()
        {
            var sum = _number1 + _number2;
            var sumType = string.Empty;

            if (sum < 0) sumType += Negative;
            else sumType += Positive;

            return sum % 2 == 0
                ? $"{sumType}-{Even}"
                : $"{sumType}-{Odd}";
        }
    }
}
