using APIProject.Core.Interfaces;

namespace APIProject.Core.Concrete
{
    public class Employee : IEmployee
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int SubtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
