namespace FourLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, m;
            bool authorizationIsPassed, result;

            Console.WriteLine("Выберите действие.\n1 - Выбор большего значения;\n2 - Конвертация метров в сантиметры;" +
                "\n3 - Дата существует?\n4 - Метод авторизации, на входе логин и пароль пользователя, на выходе bool значение;" +
                "\n5 - Метод регистрации, на входе логин, пароль, почта, дата рождения, на выходе bool.\n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Methods.Bigger(a, b));
                    break;

                case "2":
                    Console.WriteLine("введите кол-во метров для перевода в сантиметры:");
                    m = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(Methods.Metric(m));
                    break;

                case "3":
                    Console.WriteLine("введите дату для проверки:");
                    string date = Console.ReadLine();
                    bool isDate = Methods.Datetime(date);
                    if (isDate is true)
                        Console.WriteLine("Это дата");
                    else
                    {
                        Console.WriteLine("Это не дата");
                    }
                    break;

                case "4":
                    Console.WriteLine("для авторизации введите логин:");
                    string login = Console.ReadLine();
                    Console.WriteLine("для авторизации введите логин:");
                    string password = Console.ReadLine();
                    bool isAuthorized = Methods.Authorization(login, password);
                    if (isAuthorized is true) { Console.WriteLine("Авторизация прошла успешно"); }
                    else { Console.WriteLine("Ошибка авторизации"); }
                    break;

                case "5":
                    Console.WriteLine("для регистрации последовательно через Enter введите имя пользователя, пароль, почту и дату рождения");
                    string username = Console.ReadLine();
                    Console.WriteLine("введите пароль:");
                    string pwd = Console.ReadLine();
                    Console.WriteLine("введите почту:");
                    string email = Console.ReadLine();
                    Console.WriteLine("введите дату рождения:");
                    string birthday = Console.ReadLine();
                    
                    bool isRegistered = Methods.Registration(username, pwd, email, birthday);
                    if (isRegistered is true) { Console.WriteLine("Регистрация прошла успешно"); }
                                else { Console.WriteLine("Ошибка регистрации"); }
                    break;
            }
            Console.ReadKey();
        }

    }
}