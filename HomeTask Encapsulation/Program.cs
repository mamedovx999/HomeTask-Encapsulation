namespace HomeTask_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Memmedeli", "M1234MAQA435");
            user.Age = 21;
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Password);


        }
    }
}
