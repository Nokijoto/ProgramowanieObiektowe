namespace Laboratorium_2_20_10_2022.Services
{
    public class Calculate
    {
        public Calculate(int value)
        {
            Value = value;
        }

        private int Value { get; set; }
        public void Increase(int value)
        {
            Value += value;
        }
        public void Decrease(int value)
        {
            Value -= value;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
