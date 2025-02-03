public class ExampleClass{
    public int Add(int a, int b) {
        try {
            return checked(a + b);
        } catch (OverflowException ex) {
            Console.WriteLine("OverflowException caught: " + ex.Message);
            return 0; // or handle the exception appropriately
        }
    }
}