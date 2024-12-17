namespace homeWork_Smirnov_Maxim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //123456
            Console.WriteLine("Введите Вашу фамилию:");
            var secondName = Console.ReadLine();

            Console.WriteLine("Введите Ваше имя:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Введите Ваше отчество:");
            var middleName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения в формате (ДД.ММ.ГГГГ)");
            var birthDay = Console.ReadLine();

            Console.WriteLine($"Ваши данные: {secondName} {firstName} {middleName}, дата рождения: {birthDay}");

            Console.ReadKey();
        }
    }
}
