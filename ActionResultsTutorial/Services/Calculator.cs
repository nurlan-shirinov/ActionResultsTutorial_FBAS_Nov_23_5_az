namespace ActionResultsTutorial.Services
{
    public class Calculator : ICalculator
    {
        public decimal Data { get; set; } = 32;
        public Calculator()
        {
            
        }

        public decimal Calculate()
        {
           return Data+=100;
        }
    }
}
