namespace Quiz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new Launcher();

            // Pause at the end to prevent console from closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
	}
}