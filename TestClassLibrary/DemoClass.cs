namespace TestClassLibrary
{
    public class DemoClass
    {
        private int _val1, _val2;
        public DemoClass(int val1, int val2)
        {
            _val1 = val1;
            _val2 = val2;
        }

        public int Sum(int a, int b)
        {
            this.Multiply();
            return a + b;
        }

        public void Multiply()
        {
            Console.WriteLine($"Multiply {_val1 * _val2}");
        }
    }
}
