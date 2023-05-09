namespace SOLID.OCP.OCP_Voilate_Ex
{
    internal class Calculator
    {
        public void CalculatOperation(object operation)
        {
            if (operation == null) throw new ArgumentNullException("Can't Perform Operations!");

            if (operation is Addition)
            {
                Addition addition = (Addition)operation;
                addition.result = addition.num1 + addition.num2;
            }
            else if (operation is Substraction)
            {
                Substraction substraction = (Substraction)operation;
                substraction.result = substraction.num1 - substraction.num2;
            }
        }

        static void Main(string[] args)
        {
            /*
             * Here We voilate OCP principle because every time we add or extend the functionality we modify the Calulator class or module anything 
               so in this case let someone has to add multiplication ccalculation so it change or touch Calulation class every time so it's poor design and voilate OCP...
            */
            Calculator calculator = new Calculator();

            // For Addition Operation
            Addition addition = new Addition(30, 50);
            calculator.CalculatOperation(addition);
            Console.WriteLine("Addition is : " + addition.result);

            // For Substration Operation
            Substraction substraction = new Substraction(70, 50);
            calculator.CalculatOperation(substraction);
            Console.WriteLine("Substraction is : " + substraction.result);



        }
    }
}
