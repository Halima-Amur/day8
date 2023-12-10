using System.Net;

namespace day8
{
    internal class Program
    {
       public  static void Main() {
            Console.WriteLine("Enter your Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();

 
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            string sage;
            int age;
            do
            {
                sage = Console.ReadLine();
            } while (! int.TryParse(sage, out age) && (age <= 0 || age >= 100));

            Human human = new Human( Name,  address,  email, age);

            Console.WriteLine(human.greetingbyhuman());
            Human h2 = new Human();
            {
                h2.Setemail("Halima@gmail.com");
                Console.WriteLine(h2.Setemail);
            }
            phoneBook myphone = new phoneBook(5);
            myphone.addperson("halima", 9787678);
            Console.WriteLine(myphone["Halima amur"]);
            myphone["Halima"] = 8765;
            myphone.GetAll();
        }
        

                }
}

