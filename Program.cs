namespace finaltest_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetName("德明"));
        }
    }
}
