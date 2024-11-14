// Тумаков
using System;

namespace Homework
{
    /* #1 Создать перечислимый тип данных отображающий виды банковского
        счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
        значение и вывести это значение на печать. */
    enum Bankschet
    {
        Текущий,
        Сберегательный
    }
    /* #2 Создать структуру данных, которая хранит информацию о банковском
    счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
    значениями и напечатать результат. */
    public struct Bankinf
    {
        public string Nomer;
        public string Tip;
        public decimal Balanc;
        public void Print()
        {
            Console.WriteLine($"Номер счета: {Nomer}");
            Console.WriteLine($"Тип счета: {Tip}");
            Console.WriteLine($"Баланс счета: {Balanc}");
        }
    }
    /* #3 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
    структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
    распечатать. */
    public enum Univercity
    {
        KGY,
        KAI,
        KHTI
    }
    public struct Rabotnik
    {
        public string Imya;
        public Univercity Unik;
        public void Print()
        {
            Console.WriteLine($"Ваше имя: {Imya}");
            Console.WriteLine($"Ваш вуз: {Unik}");
        }
    }
    class Otvety
    {
        static void Main(string[] args)
        {
            // Ответ на 1 зад
            Bankschet schet = Bankschet.Сберегательный;
            Console.WriteLine($"Ваш тип счета: {schet}");
            Console.WriteLine();
            // Ответ на 2 зад
            Bankinf bankinf = new Bankinf();
            bankinf.Nomer = "1214 5438 9231 1234";
            bankinf.Tip = "Текущий";
            bankinf.Balanc = 1043.14m;
            bankinf.Print();
            Console.WriteLine();
            // Ответ на 3 зад
            Rabotnik infrab = new Rabotnik();
            infrab.Imya = "Сергей";
            infrab.Unik = Univercity.KGY;
            infrab.Print();
            Console.WriteLine();


        }
    }
}