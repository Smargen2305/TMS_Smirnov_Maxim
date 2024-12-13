namespace homeWork_Smirnov_Maxim_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, друг! Давай сыграем в игру. Напиши 1, если согласен.");
            var beginNumber = int.Parse(Console.ReadLine());

            if (beginNumber == 1)
            {
                Console.WriteLine("Отличный выбор, я всегда хотел с тобой поиграть!");
                Console.WriteLine("Итак, представь, что ты находишься в лесу. Перед тобой два пути: налево и направо. Куда бы ты пошел?");
                Console.WriteLine("Введите ваш выбор: налево или направо");

                var userChoice = Console.ReadLine();

                if (userChoice == "налево")
                {
                    Console.WriteLine("Ха-ха-ха, вот ты и попал в ловушку");
                }
                if (userChoice == "направо")
                {
                    Console.WriteLine("Ты встретил девушку. Вы поженились. Конец твоей игре!!!");
                }
            }
            else
            {
                Console.WriteLine("Мне очень жаль, прощай!");
            }



        }
    }
}
