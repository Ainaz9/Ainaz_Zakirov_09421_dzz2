using System;

namespace Homework
{
    // ---------------------
    // Для задания 6
    public struct Student
    {
        public string Familiya;
        public string Imya;
        public int id;
        public DateTime dr;
        public char katalk;
        public float obnapitka;
        public string tipnap;
    }
    public struct Alkogol
    {
        public string nazv;
        public double procalk;
    }
    // ---------------------
    class Zadaniya
    {
        static void Main(string[] args)
        {
            // DZ
            // /* #1 Выведите на экран информацию о каждом типе данных в виде:
            // Тип данных – максимальное значение – минимальное значение */
            Console.WriteLine("Задание 1: ");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"bool - True - False");
            Console.WriteLine($"char - {(int)char.MaxValue} - {(int)char.MinValue}");
            Console.WriteLine();
            /* #2 Напишите программу, в которой принимаются данные пользователя в виде имени,
                    города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
                    переменной, а затем распечатайте всю информацию в правильном формате. */
            Console.WriteLine("Задание 2: ");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите ваш Пин-код: ");
            string pin = Console.ReadLine();
            if (pin.Length == 4)
            {
                Console.WriteLine("Ваши данные:");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Город: {city}");
                Console.WriteLine($"Возраст: {age}");
                Console.WriteLine($"PIN-код: {pin}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Пин-код должен состоять из 4 цифр.");
            }
            /* #3 Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные. */
            Console.WriteLine("Задание 3: ");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            char[] strchar = str.ToCharArray();
            for (int i = 0; i < strchar.Length; i++)
            {
                if (char.IsLower(strchar[i]))
                {
                    strchar[i] = char.ToUpper(strchar[i]);
                }
                else if (char.IsUpper(strchar[i]))
                {
                    strchar[i] = char.ToLower(strchar[i]);
                }
            }
            string otvstr = new string(strchar);
            Console.WriteLine($"Преобразованная строка: {otvstr}");
            Console.WriteLine();
            /* #4 Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.. */
            Console.WriteLine("Задание 4: ");
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string podstroka = Console.ReadLine();
            char[] strokachar = stroka.ToCharArray();
            char podstrchar = podstroka[0];
            int kol = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (podstrchar == strokachar[i])
                {
                    kol += 1;
                }
            }
            Console.WriteLine($"Количество вхождений подстроки: {kol}");
            Console.WriteLine();

            /* #5 Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону. */
            Console.WriteLine("Задание 5: ");
            Console.Write("Введите стандартную цену: ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free: ");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            decimal economia = (normPrice * salePrice) / 100; // Находим сколько сэкономим с одной бутылки 
            decimal otvet = holidayPrice / economia; // Кол-во бутылок, кот. нужно купить чтобы накопить на отпуск
            int okrgotvet = (int)Math.Floor(otvet);
            Console.WriteLine($"Вам нужно купить {okrgotvet} бутылок, чтобы накопить на отпуск");
            Console.WriteLine();

            /*#6 Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта. */
            Console.WriteLine("Задание 6: ");
            var napitki = new List<Alkogol>
            {
                new Alkogol { nazv = "Pivo", procalk = 5 }, // Пиво 5%
                new Alkogol { nazv = "Vino", procalk = 12 }, // Вино 12%
                new Alkogol { nazv = "Vodka", procalk = 40 } // Водка 40%
            };
            var studenty = new List<Student>
            {
                new Student { Familiya = "Иванов", Imya = "Игорь", id = 1, dr = DateTime.Parse("2000-01-01"), katalk  = 'b', obnapitka = 500, tipnap  = "Pivo" },
                new Student { Familiya = "Петров", Imya = "Игорь", id = 2, dr = DateTime.Parse("2002-02-02"), katalk = 'c', obnapitka = 250, tipnap = "Vino" },
                new Student { Familiya = "Харламов", Imya = "Игорь", id = 3, dr = DateTime.Parse("2003-03-03"), katalk = 'd', obnapitka = 0, tipnap = "Нету" },
                new Student { Familiya = "Кузьмин", Imya = "Игорь", id = 4, dr = DateTime.Parse("2004-04-04"), katalk = 'a', obnapitka = 750, tipnap = "Vodka" },
                new Student { Familiya = "Васильев", Imya = "Игорь", id = 5, dr = DateTime.Parse("2005-05-05"), katalk = 'b', obnapitka = 300, tipnap = "Pivo" }
            };
            float obchob = 0; // Общий обьем выпитого
            foreach (var student in studenty)
            {
                obchob += student.obnapitka;
            }
            var obchobalk = studenty.Where(s => s.obnapitka > 0).Sum(s =>
            {
                var drink = napitki.FirstOrDefault(d => d.nazv == s.tipnap);
                return s.obnapitka * (drink.procalk / 100);
            });
            Console.WriteLine(obchob);
            Console.WriteLine(obchobalk);
            var totalDrinkVolume = studenty.Where(s => s.obnapitka > 0).Sum(s => s.obnapitka);
            var totalAlcoholVolume = studenty.Where(s => s.obnapitka > 0).Sum(s =>
            {
                var drink = napitki.FirstOrDefault(d => d.nazv == s.tipnap);
                return s.obnapitka * (drink.procalk / 100);
            });
            foreach (var student in studenty)
            {
                if (student.obnapitka == 0)
                    continue;

                var drink = napitki.FirstOrDefault(d => d.nazv == student.tipnap);
                var alcoholPercent = (student.obnapitka * (drink.procalk / 100)) / totalAlcoholVolume * 100;
                var drinkPercent = student.obnapitka / totalDrinkVolume * 100;

                Console.WriteLine($"Категория алкоголизма: {student.katalk}. Выпил {student.Familiya} {student.Imya}: {alcoholPercent:F2}% от общего объема алкоголя и {drinkPercent:F2}% от общего объема напитков.");
            }
        }
    }
}

