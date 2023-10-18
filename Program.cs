namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffeetable Agnes = new Coffeetable("black","wood",1.3,4);

            Agnes.getCoffeetable();
            Console.WriteLine();

            Chair Bosse = new Chair("White", "Metal", 0.5);
            Bosse.getChair();

        }
    }
}