using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab12_1
{
    public class Program
    {
        static int numEnter(string str, int num1 = 0, int num2 = 100000)
        {
            bool ok;
            int num;
            do
            {
                Console.Write(str + " ");
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok || num < num1 || num > num2)
                {
                    Console.WriteLine($"Число введено с ошибкой, либо вышло за допустимые пределы (от {num1} до {num2})");
                    ok = false;
                }
            } while (!ok);
            return num;
        }
        static void Main(string[] args)
        {
            //задание 1
            Place<int> place = new Place<int>();
            Area<int, string, float> area = new Area<int, string, float>();
            City<int, string, float> city = new City<int, string, float>();
            Megapolis<int, string, float> megapolis = new Megapolis<int, string, float>();
            Address<int, string, float> address = new Address<int, string, float>();
            Place<int> binPlace = new Place<int>();
            Area<int, string, float> binArea = new Area<int, string, float>();
            City<int, string, float> binCity = new City<int, string, float>();
            Megapolis<int, string, float> binMegapolis = new Megapolis<int, string, float>();
            Address<int, string, float> binAddress = new Address<int, string, float>();
            while (true)
            {
                Console.WriteLine(@"1 - Создать однонаправленный список
2 - Создать двунаправленный список
3 - Создать идеально сбалансированное дерево 
и преобразовать идеально сбалансированное дерево в дерево поиска
0 - Перейти к созданию коллекции");
                int menue = numEnter("Выберите элемент из меню", 0, 4);
                int menue1, countOfAdd;
                int averageLa;
                int averageLo;
                int count;
                if (menue == 0)
                {
                    break;
                }
                switch (menue)
                {
                    case 1:
                        Console.WriteLine(@"1 - Place
2 - Area
3 - City
4 - Megapolis
5 - Address
0 - Назад");
                        menue1 = numEnter("Выберите элемент из меню", 0, 6);
                        if (menue1 == 0)
                        {
                            break;
                        }
                        switch (menue1)
                        {
                            case 1:
                                place = MakeList(numEnter("Введите количество элементов в списке", 0, 100));//1.1
                                ShowList(place);//1.2
                                place = AddNext(place, numEnter("Введите на какое место в списке вставить новый элемент", 0, 100));//1.3
                                ShowList(place);//1.4
                                place = null;//1.5
                                break;
                            case 2:
                                area = MakeListArea(numEnter("Введите количество элементов в списке", 0, 100));//1.1
                                ShowList(area);//1.2
                                area = AddNext(area, numEnter("Введите на какое место в списке вставить новый элемент", 0, 100));//1.3
                                ShowList(area);//1.4
                                area = null;//1.5
                                break;
                            case 3:
                                city = MakeListCity(numEnter("Введите количество элементов в списке", 0, 100));//1.1
                                ShowList(city);//1.2
                                city = AddNext(city, numEnter("Введите на какое место в списке вставить новый элемент", 0, 100));//1.3
                                ShowList(city);//1.4
                                city = null;//1.5
                                break;
                            case 4:
                                megapolis = MakeListMegapolice(numEnter("Введите количество элементов в списке", 0, 100));//1.1
                                ShowList(megapolis);//1.2
                                megapolis = AddNext(megapolis, numEnter("Введите на какое место в списке вставить новый элемент", 0, 100));//1.3
                                ShowList(megapolis);//1.4
                                megapolis = null;//1.5
                                break;
                            case 5:
                                address = MakeListAddress(numEnter("Введите количество элементов в списке", 0, 100));//1.1
                                ShowList(address);//1.2
                                address = AddNext(address, numEnter("Введите на какое место в списке вставить новый элемент", 0, 100));//1.3
                                ShowList(address);//1.4
                                address = null;//1.5
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine(@"1 - Place
2 - Area
3 - City
4 - Megapolis
5 - Address
0 - Назад");
                        menue1 = numEnter("Выберите элемент из меню", 0, 6);
                        if (menue1 == 0)
                        {
                            break;
                        }
                        switch (menue1)
                        {
                            case 1:
                                countOfAdd = numEnter("Введите количество элементов в списке", 0, 100);
                                place = MakeListLR(countOfAdd);//1.6
                                ShowTree(place);//1.7
                                Console.WriteLine();
                                Console.WriteLine("Удаляем......");
                                Console.WriteLine();
                                for (int i = 2; i < countOfAdd; i++)
                                {
                                    place = Delete(place, i);
                                    countOfAdd--;
                                };//1.8
                                ShowTree(place);//1.9
                                place = null;//1.10
                                break;
                            case 2:
                                countOfAdd = numEnter("Введите количество элементов в списке", 0, 100);
                                area = MakeListLRArea(countOfAdd);//1.6
                                ShowTree(area);//1.7
                                Console.WriteLine();
                                Console.WriteLine("Удаляем......");
                                Console.WriteLine();
                                for (int i = 2; i < countOfAdd; i++)
                                {
                                    area = Delete(area, i);
                                    countOfAdd--;
                                };//1.8
                                ShowTree(area);//1.9
                                area = null;//1.10
                                break;
                            case 3:
                                countOfAdd = numEnter("Введите количество элементов в списке", 0, 100);
                                city = MakeListLRCity(countOfAdd);//1.6
                                ShowTree(city);//1.7
                                Console.WriteLine();
                                Console.WriteLine("Удаляем......");
                                Console.WriteLine();
                                for (int i = 2; i < countOfAdd; i++)
                                {
                                    city = Delete(city, i);
                                    countOfAdd--;
                                };//1.8
                                ShowTree(city);//1.9
                                city = null;//1.10
                                break;
                            case 4:
                                countOfAdd = numEnter("Введите количество элементов в списке", 0, 100);
                                megapolis = MakeListLRMegapolice(countOfAdd);//1.6
                                ShowTree(city);//1.7
                                Console.WriteLine();
                                Console.WriteLine("Удаляем......");
                                Console.WriteLine();
                                for (int i = 2; i < countOfAdd; i++)
                                {
                                    megapolis = Delete(megapolis, i);
                                    countOfAdd--;
                                };//1.8
                                ShowTree(megapolis);//1.9
                                megapolis = null;//1.10
                                break;
                            case 5:
                                countOfAdd = numEnter("Введите количество элементов в списке", 0, 100);
                                address = MakeListLRAddress(countOfAdd);//1.6
                                ShowTree(address);//1.7
                                Console.WriteLine();
                                Console.WriteLine("Удаляем......");
                                Console.WriteLine();
                                for (int i = 2; i < countOfAdd; i++)
                                {
                                    address = Delete(address, i);
                                    countOfAdd--;
                                };//1.8
                                ShowTree(address);//1.9
                                address = null;//1.10
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(@"1 - Place
2 - Area
3 - City
4 - Megapolis
5 - Address
0 - Назад");
                        menue1 = numEnter("Выберите элемент из меню", 0, 6);
                        if (menue1 == 0)
                        {
                            break;
                        }
                        switch (menue1)
                        {
                            case 1:
                                place = IdealTree(numEnter("Введите количество элементов в списке", 0, 100), place);//1.11
                                ShowTree(place);//1.12
                                averageLa = 0;
                                averageLo = 0;
                                count = 0;
                                Average(place, ref averageLa, ref averageLo, ref count);
                                if (count != 0)
                                {
                                    Console.WriteLine($"Средняя широта: {averageLa / count}, Средняя долгота: {averageLo / count}");//1.13
                                }
                                else
                                { 
                                    Console.WriteLine("Список пуст"); 
                                }
                                binPlace = null;
                                CreationBinaryTree(place, ref binPlace);//1.14
                                ShowTree(binPlace);//1.15
                                place = null;//1.16
                                binPlace = null;//1.16
                                break;
                            case 2:
                                area = IdealTree(numEnter("Введите количество элементов в списке", 0, 100), area);//1.11
                                ShowTree(area);//1.12
                                averageLa = 0;
                                averageLo = 0;
                                count = 0;
                                Average(area, ref averageLa, ref averageLo, ref count);
                                Console.WriteLine($"Средняя широта: {averageLa / count}, Средняя долгота: {averageLo / count}");//1.13
                                binArea = null;
                                CreationBinaryTree(area, ref binArea);//1.14
                                ShowTree(binArea);//1.15
                                area = null;//1.16
                                binArea = null;//1.16
                                break;
                            case 3:
                                city = IdealTree(numEnter("Введите количество элементов в списке", 0, 100), city);//1.11
                                ShowTree(city);//1.12
                                averageLa = 0;
                                averageLo = 0;
                                count = 0;
                                Average(city, ref averageLa, ref averageLo, ref count);
                                Console.WriteLine($"Средняя широта: {averageLa / count}, Средняя долгота: {averageLo / count}");//1.13
                                binCity = null;
                                CreationBinaryTree(city, ref binCity);//1.14
                                ShowTree(binCity);//1.15
                                city = null;//1.16
                                binCity = null;//1.16
                                break;
                            case 4:
                                megapolis = IdealTree(numEnter("Введите количество элементов в списке", 0, 100), megapolis);//1.11
                                ShowTree(megapolis);//1.12
                                averageLa = 0;
                                averageLo = 0;
                                count = 0;
                                Average(megapolis, ref averageLa, ref averageLo, ref count);
                                Console.WriteLine($"Средняя широта: {averageLa / count}, Средняя долгота: {averageLo / count}");//1.13
                                binMegapolis = null;
                                CreationBinaryTree(megapolis, ref binMegapolis);//1.14
                                ShowTree(binMegapolis);//1.15
                                megapolis = null;//1.16
                                binMegapolis = null;//1.16
                                break;
                            case 5:
                                address = IdealTree(numEnter("Введите количество элементов в списке", 0, 100), address);//1.11
                                ShowTree(address);//1.12
                                averageLa = 0;
                                averageLo = 0;
                                count = 0;
                                Average(address, ref averageLa, ref averageLo, ref count);
                                Console.WriteLine($"Средняя широта: {averageLa / count}, Средняя долгота: {averageLo / count}");//1.13
                                binAddress = null;
                                CreationBinaryTree(address, ref binAddress);//1.14
                                ShowTree(binAddress);//1.15
                                address = null;//1.16
                                binAddress = null;//1.16
                                break;
                        }
                        break;
                }
            }
            //задание 2
            Stack<int> stack = new Stack<int>();
            LRList<int> list = new LRList<int>();
            while (true)
            {
                Console.WriteLine(@"1 - Place
2 - Area
3 - City
4 - Megapolis
5 - Address
6 - Добавить в стек
0 - Закончить заполнение");
                int menue1 = numEnter("Выберите элемент из меню", 0, 6);
                if (menue1 == 0)
                {
                    break;
                }
                switch (menue1)
                {
                    case 1:
                        list.Add(MakePlace());
                        break;
                    case 2:
                        list.Add(MakeArea());
                        break;
                    case 3:
                        list.Add(MakeCity());
                        break;
                    case 4:
                        list.Add(MakeMegapolis());
                        break;
                    case 5:
                        list.Add(MakeAddress());
                        break;
                    case 6:
                        stack.Push(list);
                        list = new LRList<int>();
                        break;
                }
            }
            foreach( int s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"Количество элементов в стеке = {stack.Count}");
            LRList<int> list1 = new LRList<int>();
            List<LRList<int>> list2 = new List<LRList<int>>();
            for(int i  = 0; i < 3; i++)
            {
                list1 = new LRList<int>();
                for (int j = 0; j < 3; j++)
                {
                    list1.Add(MakePlace());
                }
                list2.Add(list1);
            }
            stack = new Stack<int>(list2);
            Stack<int> clone1 =(Stack<int>) stack.Clone();
            LRList<int> clone2 = (LRList<int>) list1.Clone();
            ShowTree(list1.Root);
            ShowTree(clone2.Root);
            for (int i = 0; i < stack.Count; i++)
            {
                ShowTree(stack.Pop().Root);
            }
            clone1 = clone1.ShallowCopy();
            clone2 = list1.ShallowCopy();

            foreach(int s in clone2)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < stack.Count; i++)
            {
                ShowTree(stack.Pop().Root);
            }
            try
            {
                Console.WriteLine(list1.Find(numEnter("Введите долготу", -90, 91), numEnter("Введите широту", -180, 181)));
                
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Не найдено");
            }
            try
            {
                list1.Remove(list1.Find(numEnter("Введите долготу", -90, 91), numEnter("Введите широту", -180, 181)));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Не найдено");
            }
        }

        static string RandomWord()
        {

            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] letters1 = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            // Создаем генератор случайных чисел.
            Random rand = new Random();
            int num_letters = rand.Next(0, 15);
            // Делаем слова.
            string word = "" + letters[rand.Next(0, letters.Length - 1)];
            for (int j = 1; j <= num_letters; j++)
            {
                // Выбор случайного числа от 0 до 25
                // для выбора буквы из массива букв.
                int letter_num = rand.Next(0, letters.Length - 1);

                // Добавить письмо.
                word += letters[letter_num];
            }
            return word;


        }
        static Place<int> MakePlace( )
        {
            Random rnd = new Random();
            Place<int> p = new Place<int>(rnd.Next(-90,91), rnd.Next(-180, 181));
            return p;
        }
        static Area<int, string, float> MakeArea()
        {
            Random rnd = new Random();
            Place<int> pl = new Place<int>(rnd.Next(-90, 91), rnd.Next(-180, 181));
            Area<int, string, float> ar = new Area<int, string, float>(pl, RandomWord(), rnd.Next(1, 100), (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000);
            return ar;
        }
        static City<int, string, float> MakeCity()
        {
            Random rnd = new Random();
            Place<int> pl = new Place<int>(rnd.Next(-90, 91), rnd.Next(-180, 181));
            Area<int, string, float> ar = new Area<int, string, float>(pl, RandomWord(), rnd.Next(1, 100), (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000);
            City<int, string, float> ct = new City<int, string, float>(ar, RandomWord(), rnd.Next(1, 100000000), (float)rnd.Next(0, 500) + (float)(rnd.Next(1, 999)) / 1000);
            return ct;
        }
        static Megapolis<int, string, float> MakeMegapolis()
        {
            Random rnd = new Random();
            Place<int> pl = new Place<int>(rnd.Next(-90, 91), rnd.Next(-180, 181));
            Area<int, string, float> ar = new Area<int, string, float>(pl, RandomWord(), rnd.Next(1, 100), (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000);
            City<int, string, float> ct = new City<int, string, float>(ar, RandomWord(), rnd.Next(1, 100000000), (float)rnd.Next(0, 500) + (float)(rnd.Next(1, 999)) / 1000);
            Megapolis<int, string, float> mg = new Megapolis<int, string, float>(ct, RandomWord(), rnd.Next(1, 10));
            return mg;
        }
        static Megapolis<int, string, float> MakeAddress()
        {
            Random rnd = new Random();
            Place<int> pl = new Place<int>(rnd.Next(-90, 91), rnd.Next(-180, 181));
            Area<int, string, float> ar = new Area<int, string, float>(pl, RandomWord(), rnd.Next(1, 100), (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000);
            City<int, string, float> ct = new City<int, string, float>(ar, RandomWord(), rnd.Next(1, 100000000), (float)rnd.Next(0, 500) + (float)(rnd.Next(1, 999)) / 1000);
            
            Address<int, string, float> ad = new Address<int, string, float>(ct, RandomWord(), rnd.Next(1, 500)); 
            if (rnd.Next(0,2) == 1)
            {
                Megapolis<int, string, float> mg = new Megapolis<int, string, float>(ct, RandomWord(), rnd.Next(1, 10));
                ad = new Address<int, string, float>(mg, RandomWord(), rnd.Next(1, 500));
            }
            return ad;
        }

        #region Place
        static Place<int> MakePlace(int la, int lo)
        {
            Place<int> p = new Place<int>(la, lo);
            return p;
        }
        
        static Place<int> MakeList(int size)
        {
            if (size != 0) 
            {
                Random rnd = new Random();
                int info1 = rnd.Next(-90, 91);
                int info2 = rnd.Next(-180, 181);
                Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
                Place<int> beg = MakePlace(info1, info2);//создаем первый элемент
                for (int i = 1; i < size; i++)
                {
                    info1 = rnd.Next(-90, 91);
                    info2 = rnd.Next(-180, 181);
                    Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
                    //создаем элемент и добавляем в начало списка
                    Place<int> p = MakePlace(info1, info2);
                    p.next = beg;
                    beg = p;
                }
                return beg;
            }
            else
            {
                return null;
            }

        }
        static Place<int> AddNext(Place<int> beg, int number)
        {
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
            //создаем новый элемент
            Place<int> NewPlace = MakePlace(info1, info2);
            if (beg is null)//список пустой
            {
                beg = MakePlace(rnd.Next(-90, 90), rnd.Next(-180, 180));
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                NewPlace.next = beg;
                beg = NewPlace;
                return beg;
            }
            //вспом. переменная для прохода по списку
            Place<int> p = beg;
            //идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && !(p is null); i++)
                p = p.next;
            if (p is null)//элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше введенного числа!");
                return beg;
            }
            //добавляем новый элемент
            NewPlace.next = p.next;
            p.next = NewPlace;
            return beg;
        }
        static void ShowList(Place<int> beg)
        {
            //проверка наличия элементов в списке
            if (beg is null)
            {
                Console.WriteLine("Лист пуст");
                return;
            }
            Place<int> p = beg;
            while (!(p is null))
            {
                Console.Write(p + " ");
                p = p.next;//переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(Place<int> p)
        {
            if (!(p is null))
            {

                ShowTree(p.right);//переход к левому поддереву 
                ShowTree(p.left);//переход к правому поддереву
                Console.WriteLine(p);
            }
        }
        static Place<int> MakeListLR(int num)
        {
            if (num == 0) return null;
            Random rnd = new Random();
            num--;
            int num1 = num / 2;

            int num2 = num - num1;
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
            Place<int> beg = MakePlace(info1, info2);
            Place<int> p = beg;//создаем первый элемент
            for (int i = 1; i < num1 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
                //создаем элемент и добавляем в начало списка
                p.left = MakePlace(info1, info2);
                p = p.left;
            }
            p = beg;
            for (int i = 1; i < num2 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                Console.WriteLine("Элемент {0} и {1} добавляются...", info1, info2);
                //создаем элемент и добавляем в начало списка
                p.right = MakePlace(info1, info2);
                p = p.right;
            }
            return beg;
        }
        static Place<int> Delete(Place<int> beg, int number)
        {

            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return null;
            }
            if (number == 1)//удаляем первый элемент
            {
                beg = beg.right;
                return beg;
            }
            Place<int> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.right is null); i++)
                p = p.right;
            if (i < number - 1)
            {
                p = beg;
                for (; i < number - 1 && !(p.left is null); i++)
                    p = p.left;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                return beg;
            }
            //исключаем элемент из списка

            if (!(p.right is null))
                p.right = p.right.right;
            else if (!(p.left is null))
                p.left = p.left.left;
            else if (p.left is null && !(p is null))
                p = null;

            return beg;


        }

        static Place<int> IdealTree(int size, Place<int> p)
        {
            Place<int> r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            Random rnd = new Random();
            int number1 = rnd.Next(-90, 91);
            int number2 = rnd.Next(-180, 181);
            r = new Place<int>(number1, number2);
            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            return r;
        }
        static void Average(Place<int> p, ref int laA, ref int loA, ref int count)
        {
            if (!(p is null))
            {

                Average(p.left, ref laA, ref loA, ref count);
                laA += p.latitude;
                loA += p.longitude;
                count++;
                Average(p.right, ref laA, ref loA, ref count);
            }
        }
        static void CreationBinaryTree(Place<int> root, ref Place<int> binTree, bool first = true)
        {

            if (!(root is null))
            {
                if (first)
                {
                    binTree = new Place<int>(root.latitude, root.longitude);
                }
                else
                {
                    Place<int> NewPoint = new Place<int>(root.latitude, root.longitude);
                    binTree = Add(binTree, NewPoint);
                }
                CreationBinaryTree(root.left, ref binTree, false);

                CreationBinaryTree(root.right, ref binTree, false);
            }
        }
        static Place<int> Add(Place<int> root, Place<int> NewPoint)
        {
            Place<int> p = root; //корень дерева
            Place<int> r = null;
            //флаг для проверки существования элемента d в дереве
            bool ok = false;
            while (!(p is null) && !ok)
            {
                r = p;
                //элемент уже существует
                if (NewPoint == p && NewPoint == p) ok = true;
                else
            if (NewPoint < p) p = p.left; //пойти в левое поддерево
                else p = p.right; //пойти в правое поддерево
            }
            if (ok) return p;//найдено, не добавляем
                             //создаем узел
                             //выделили память
                             // если d<r.key, то добавляем его в левое поддерево
            if (NewPoint < r) r.left = NewPoint;
            // если d>r.key, то добавляем его в правое поддерево
            else r.right = NewPoint;
            r = root;
            return r;
        }
        #endregion
        #region Area
        public static Area<int, string, float> MakeArea(Place<int> pl, string na, int co, float sq)
        {
            Area<int, string, float> ar = new Area<int, string, float>(pl, na, co, sq);
            return ar;
        }

        static Area<int, string, float> MakeListArea(int size)
        {
            if (size != 0)
            {
                Random rnd = new Random();
                int info1 = rnd.Next(-90, 91);
                int info2 = rnd.Next(-180, 181);
                string str = RandomWord();
                int co = rnd.Next(0, 100);
                float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
                Area<int, string, float> beg = MakeArea(pl, str, co, sq);
                for (int i = 1; i < size; i++)
                {
                    info1 = rnd.Next(-90, 91);
                    info2 = rnd.Next(-180, 181);
                    str = RandomWord();
                    co = rnd.Next(0, 100);
                    sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                    Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                    //создаем элемент и добавляем в начало списка
                    pl = MakePlace(info1, info2);
                    Area<int, string, float> p = MakeArea(pl, str, co, sq);
                    p.next = beg;
                    beg = p;
                }
                return beg;
            }
            return null;
        }
        static Area<int, string, float> AddNext(Area<int, string, float> beg, int number)
        {

            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> NewArea = MakeArea(pl, str, co, sq);
            if (beg is null)//список пустой
            {
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                beg = MakeArea(MakePlace(rnd.Next(-90, 91), rnd.Next(-180, 181)), str, co, sq);
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                NewArea.next = beg;
                beg = NewArea;
                return beg;
            }
            //вспом. переменная для прохода по списку
            Area<int, string, float> p = beg;
            //идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && !(p is null); i++)
                p = p.next;
            if (p is null)//элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше введенного числа!");
                return beg;
            }
            //добавляем новый элемент
            NewArea.next = p.next;
            p.next = NewArea;
            return beg;
        }
        static void ShowList(Area<int, string, float> beg)
        {
            //проверка наличия элементов в списке
            if (beg is null)
            {
                Console.WriteLine("Лист пуст");
                return;
            }
            Area<int, string, float> p = beg;
            while (!(p is null))
            {
                Console.Write(p + " ");
                p = p.next;//переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(Area<int, string, float> p)
        {
            if (!(p is null))
            {

                ShowTree(p.right);//переход к левому поддереву 
                ShowTree(p.left);//переход к правому поддереву
                Console.WriteLine(p);
            }
        }
        static Area<int, string, float> MakeListLRArea(int num)
        {
            if (num == 0) return null;
            Random rnd = new Random();
            num--;
            int num1 = num / 2;

            int num2 = num - num1;
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> beg = MakeArea(pl, str, co, sq);
            Area<int, string, float> p = beg;
            for (int i = 1; i < num1 + 1; i++)
            {

                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                //создаем элемент и добавляем в начало списка
                pl = MakePlace(info1, info2);
                p.left = MakeArea(pl, str, co, sq);
                p = p.left;
                
            }
            p = beg;
            for (int i = 1; i < num2 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                //создаем элемент и добавляем в начало списка
                pl = MakePlace(info1, info2);
                p.right = MakeArea(pl, str, co, sq);
                p = p.right;
            }
            return beg;
        }
        static Area<int, string, float> Delete(Area<int, string, float> beg, int number)
        {

            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return null;
            }
            if (number == 1)//удаляем первый элемент
            {
                beg = beg.right;
                return beg;
            }
            Area<int, string, float> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.right is null); i++)
                p = p.right;
            if (i < number - 1)
            {
                for (; i < number - 1 && !(p.left is null); i++)
                    p = p.left;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                return beg;
            }
            //исключаем элемент из списка
            if (!(p.right is null) && !(p.right.right is null))
                p.right = p.right.right;
            else if (!(p.right is null) && p.right.right is null && !(p.right.left is null))
                p.right = p.right.left;
            else if (!(p.left is null))
                p.left = p.left.left;
            else if (p.left is null && !(p is null))
                p = null;

            return beg;


        }

        static Area<int, string, float> IdealTree(int size, Area<int, string, float> p)
        {
            Area<int, string, float> r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            r = new Area<int, string, float>(pl, str, co, sq);
            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            return r;
        }
        static void Average(Area<int, string, float> p, ref int laA, ref int loA, ref int count)
        {
            if (!(p is null))
            {

                Average(p.left, ref laA, ref loA, ref count);
                laA += p.latitude;
                loA += p.longitude;
                count++;
                Average(p.right, ref laA, ref loA, ref count);
            }
        }
        static void CreationBinaryTree(Area<int, string, float> root, ref Area<int, string, float> binTree, bool first = true)
        {

            if (!(root is null))
            {
                if (first)
                {
                    binTree = new Area<int, string, float>(new Place<int>(root.latitude, root.longitude), root.nameOfArea, root.countOfCity, root.squearOfArea);
                }
                else
                {
                    Area<int, string, float> NewPoint = new Area<int, string, float>(new Place<int>(root.latitude, root.longitude), root.nameOfArea, root.countOfCity, root.squearOfArea);
                    binTree = Add(binTree, NewPoint);
                }
                CreationBinaryTree(root.left, ref binTree, false);

                CreationBinaryTree(root.right, ref binTree, false);
            }
        }
        static Area<int, string, float> Add(Area<int, string, float> root, Area<int, string, float> NewPoint)
        {
            Area<int, string, float> p = root; //корень дерева
            Area<int, string, float> r = null;
            //флаг для проверки существования элемента d в дереве
            bool ok = false;
            while (!(p is null) && !ok)
            {
                r = p;
                //элемент уже существует
                if (NewPoint == p && NewPoint == p) ok = true;
                else
            if (NewPoint < p) p = p.left; //пойти в левое поддерево
                else p = p.right; //пойти в правое поддерево
            }
            if (ok) return p;//найдено, не добавляем
                             //создаем узел
                             //выделили память
                             // если d<r.key, то добавляем его в левое поддерево
            if (NewPoint < r) r.left = NewPoint;
            // если d>r.key, то добавляем его в правое поддерево
            else r.right = NewPoint;
            r = root;
            return r;
        }
        #endregion
        #region City
        public static City<int, string, float> MakeCity(Area<int, string, float> pl, string na, int co, float sq)
        {
            City<int, string, float> ct = new City<int, string, float>(pl, na, co, sq);
            return ct;
        }

        static City<int, string, float> MakeListCity(int size)
        {
            if (size != 0)
            {
                Random rnd = new Random();
                int info1 = rnd.Next(-90, 91);
                int info2 = rnd.Next(-180, 181);
                string str = RandomWord();
                int co = rnd.Next(0, 100);
                float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

                Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
                Area<int, string, float> ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                City<int, string, float> beg = MakeCity(ar, str, co, sq);
                for (int i = 1; i < size; i++)
                {
                    info1 = rnd.Next(-90, 91);
                    info2 = rnd.Next(-180, 181);
                    str = RandomWord();
                    co = rnd.Next(0, 100);
                    sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                    pl = MakePlace(info1, info2);
                    ar = MakeArea(pl, str, co, sq);
                    str = RandomWord();
                    co = rnd.Next(100, 1000000);
                    sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                    Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                    City<int, string, float> p = MakeCity(ar, str, co, sq);
                    p.next = beg;
                    beg = p;
                }
                return beg;
            }
            return null;
        }
        static City<int, string, float> AddNext(City<int, string, float> beg, int number)
        {
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            City<int, string, float> NewCity = MakeCity(ar, str, co, sq);
            if (beg is null)//список пустой
            {
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Area<int, string, float> area = MakeArea(MakePlace(rnd.Next(-90, 91), rnd.Next(-180, 181)), str, co, sq);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                beg = MakeCity(area, str, co, sq);
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                NewCity.next = beg;
                beg = NewCity;
                return beg;
            }
            //вспом. переменная для прохода по списку
            City<int, string, float> p = beg;
            //идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && !(p is null); i++)
                p = p.next;
            if (p is null)//элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше введенного числа!");
                return beg;
            }
            //добавляем новый элемент
            NewCity.next = p.next;
            p.next = NewCity;
            return beg;
        }
        static void ShowList(City<int, string, float> beg)
        {
            //проверка наличия элементов в списке
            if (beg is null)
            {
                Console.WriteLine("Лист пуст");
                return;
            }
            City<int, string, float> p = beg;
            while (!(p is null))
            {
                Console.Write(p + " ");
                p = p.next;//переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(City<int, string, float> p)
        {
            if (!(p is null))
            {

                ShowTree(p.right);//переход к левому поддереву 
                ShowTree(p.left);//переход к правому поддереву
                Console.WriteLine(p);
            }
        }
        static City<int, string, float> MakeListLRCity(int num)
        {
            if (num == 0) return null;
            Random rnd = new Random();
            num--;
            int num1 = num / 2;
            int num2 = num - num1;
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            City<int, string, float> beg = MakeCity(ar, str, co, sq);
            City<int, string, float> p = beg;
            for (int i = 1; i < num1 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                p.left = MakeCity(ar, str, co, sq);
                p  = p.left;
            }
            p = beg;
            for (int i = 1; i < num2 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                p.right = MakeCity(ar, str, co, sq);
                p= p.right;
            }
            return beg;
        }
        static City<int, string, float> Delete(City<int, string, float> beg, int number)
        {

            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return null;
            }
            if (number == 1)//удаляем первый элемент
            {
                beg = beg.right;
                return beg;
            }
            City<int, string, float> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.right is null); i++)
                p = p.right;
            if (i < number - 1)
            {
                for (; i < number - 1 && !(p.left is null); i++)
                    p = p.left;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                return beg;
            }
            //исключаем элемент из списка
            if (!(p.right is null) && !(p.right.right is null))
                p.right = p.right.right;
            else if (!(p.right is null) && p.right.right is null && !(p.right.left is null))
                p.right = p.right.left;
            else if (!(p.left is null))
                p.left = p.left.left;
            else if (p.left is null && !(p is null))
                p = null;

            return beg;


        }

        static City<int, string, float> IdealTree(int size, City<int, string, float> p)
        {
            City<int, string, float> r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = new Area<int, string, float>(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
            r = MakeCity(ar, str, co, sq);

            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            return r;
        }
        static void Average(City<int, string, float> p, ref int laA, ref int loA, ref int count)
        {
            if (!(p is null))
            {

                Average(p.left, ref laA, ref loA, ref count);
                laA += p.latitude;
                loA += p.longitude;
                count++;
                Average(p.right, ref laA, ref loA, ref count);
            }
        }
        static void CreationBinaryTree(City<int, string, float> root, ref City<int, string, float> binTree, bool first = true)
        {

            if (!(root is null))
            {
                if (first)
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    binTree = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                }
                else
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    City<int, string, float> NewPoint = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                    binTree = Add(binTree, NewPoint);
                }
                CreationBinaryTree(root.left, ref binTree, false);

                CreationBinaryTree(root.right, ref binTree, false);
            }

        }
        static City<int, string, float> Add(City<int, string, float> root, City<int, string, float> NewPoint)
        {
            City<int, string, float> p = root; //корень дерева
            City<int, string, float> r = null;
            //флаг для проверки существования элемента d в дереве
            bool ok = false;
            while (!(p is null) && !ok)
            {
                r = p;
                //элемент уже существует
                if (NewPoint == p && NewPoint == p) ok = true;
                else
            if (NewPoint < p) p = p.left; //пойти в левое поддерево
                else p = p.right; //пойти в правое поддерево
            }
            if (ok) return p;//найдено, не добавляем
                             //создаем узел
                             //выделили память
                             // если d<r.key, то добавляем его в левое поддерево
            if (NewPoint < r) r.left = NewPoint;
            // если d>r.key, то добавляем его в правое поддерево
            else r.right = NewPoint;
            r = root;
            return r;
        }
        #endregion
        #region Megapolis
        public static Megapolis<int, string, float> MakeMegapolice(City<int, string, float> pl, string na, int co)
        {
            Megapolis<int, string, float> mg = new Megapolis<int, string, float>(pl, na, co);
            return mg;
        }

        static Megapolis<int, string, float> MakeListMegapolice(int size)
        {
            if (size == 0) return null;
                Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            City<int, string, float> ct = MakeCity(ar, str, co, sq);

            str = RandomWord();
            co = rnd.Next(1, 10);
            Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
            Megapolis<int, string, float> beg = MakeMegapolice(ct, str, co);
            for (int i = 1; i < size; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                ct = MakeCity(ar, str, co, sq);
                str = RandomWord();
                co = rnd.Next(1, 10);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                Megapolis<int, string, float> p = MakeMegapolice(ct, str, co);
                p.next = beg;
                beg = p;
            }
            return beg;
        }
        static Megapolis<int, string, float> AddNext(Megapolis<int, string, float> beg, int number)
        {
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            str = RandomWord();
            co = rnd.Next(1, 10);
            Console.WriteLine("Элементы {0}, {1}   добавляются...", str, co);
            Megapolis<int, string, float> NewMegapolice = MakeMegapolice(ct, str, co);
            if (beg is null)//список пустой
            {
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Area<int, string, float> area = MakeArea(MakePlace(rnd.Next(-90, 91), rnd.Next(-180, 181)), str, co, sq);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                City<int, string, float> city = MakeCity(area, str, co, sq);
                str = RandomWord();
                co = rnd.Next(1, 10);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                beg = MakeMegapolice(ct, str, co);
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                NewMegapolice.next = beg;
                beg = NewMegapolice;
                return beg;
            }
            //вспом. переменная для прохода по списку
            Megapolis<int, string, float> p = beg;
            //идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && !(p is null); i++)
                p = p.next;
            if (p is null)//элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше введенного числа!");
                return beg;
            }
            //добавляем новый элемент
            NewMegapolice.next = p.next;
            p.next = NewMegapolice;
            return beg;
        }
        static void ShowList(Megapolis<int, string, float> beg)
        {
            //проверка наличия элементов в списке
            if (beg is null)
            {
                Console.WriteLine("Лист пуст");
                return;
            }
            Megapolis<int, string, float> p = beg;
            while (!(p is null))
            {
                Console.Write(p + " ");
                p = p.next;//переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(Megapolis<int, string, float> p)
        {
            if (!(p is null))
            {

                ShowTree(p.right);//переход к левому поддереву 
                ShowTree(p.left);//переход к правому поддереву
                Console.WriteLine(p);
            }
        }
        static Megapolis<int, string, float> MakeListLRMegapolice(int num)
        {
            if (num == 0) return null;
            Random rnd = new Random();
            num--;
            int num1 = num / 2;
            int num2 = num - num1;
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            str = RandomWord();
            co = rnd.Next(1, 10);
            Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
            Megapolis<int, string, float> beg = MakeMegapolice(ct, str, co);
            Megapolis<int, string, float> p = beg;
            for (int i = 1; i < num1 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                ct = MakeCity(ar, str, co, sq);
                str = RandomWord();
                co = rnd.Next(1, 10);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                p.left = MakeMegapolice(ct, str, co);
                p  = p.left ;
            }
            p = beg;
            for (int i = 1; i < num2 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                ct = MakeCity(ar, str, co, sq);
                str = RandomWord();
                co = rnd.Next(1, 10);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                p.right = MakeMegapolice(ct, str, co);
                p = p.right;
            }
            return beg;
        }
        static Megapolis<int, string, float> Delete(Megapolis<int, string, float> beg, int number)
        {

            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return null;
            }
            if (number == 1)//удаляем первый элемент
            {
                beg = beg.right;
                return beg;
            }
            Megapolis<int, string, float> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.right is null); i++)
                p = p.right;
            if (i < number - 1)
            {
                for (; i < number - 1 && !(p.left is null); i++)
                    p = p.left;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                return beg;
            }
            //исключаем элемент из списка
            if (!(p.right is null) && !(p.right.right is null))
                p.right = p.right.right;
            else if (!(p.right is null) && p.right.right is null && !(p.right.left is null))
                p.right = p.right.left;
            else if (!(p.left is null))
                p.left = p.left.left;
            else if (p.left is null && !(p is null))
                p = null;

            return beg;


        }

        static Megapolis<int, string, float> IdealTree(int size, Megapolis<int, string, float> p)
        {
            Megapolis<int, string, float> r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = new Area<int, string, float>(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            str = RandomWord();
            co = rnd.Next(1, 10);
            Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
            r = MakeMegapolice(ct, str, co);
            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            return r;
        }
        static void Average(Megapolis<int, string, float> p, ref int laA, ref int loA, ref int count)
        {
            if (!(p is null))
            {

                Average(p.left, ref laA, ref loA, ref count);
                laA += p.latitude;
                loA += p.longitude;
                count++;
                Average(p.right, ref laA, ref loA, ref count);
            }
        }
        static void CreationBinaryTree(Megapolis<int, string, float> root, ref Megapolis<int, string, float> binTree, bool first = true)
        {

            if (!(root is null))
            {
                if (first)
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    City<int, string, float> ct = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                    binTree = new Megapolis<int, string, float>(ct, root.nameOfMegapolice, root.countOfAglommeration);
                }
                else
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    City<int, string, float> ct = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                    Megapolis<int, string, float> NewPoint = new Megapolis<int, string, float>(ct, root.nameOfMegapolice, root.countOfAglommeration);
                    binTree = Add(binTree, NewPoint);
                }
                CreationBinaryTree(root.left, ref binTree, false);

                CreationBinaryTree(root.right, ref binTree, false);
            }

        }
        static Megapolis<int, string, float> Add(Megapolis<int, string, float> root, Megapolis<int, string, float> NewPoint)
        {
            Megapolis<int, string, float> p = root; //корень дерева
            Megapolis<int, string, float> r = null;
            //флаг для проверки существования элемента d в дереве
            bool ok = false;
            while (!(p is null) && !ok)
            {
                r = p;
                //элемент уже существует
                if (NewPoint == p && NewPoint == p) ok = true;
                else
            if (NewPoint < p) p = p.left; //пойти в левое поддерево
                else p = p.right; //пойти в правое поддерево
            }
            if (ok) return p;//найдено, не добавляем
                             //создаем узел
                             //выделили память
                             // если d<r.key, то добавляем его в левое поддерево
            if (NewPoint < r) r.left = NewPoint;
            // если d>r.key, то добавляем его в правое поддерево
            else r.right = NewPoint;
            r = root;
            return r;
        }
        #endregion
        #region Address 
        public static Address<int, string, float> MakeAddress(Megapolis<int, string, float> pl, string na, int co)
        {
            Address<int, string, float> ad = new Address<int, string, float>(pl, na, co);
            return ad;
        }
        public static Address<int, string, float> MakeAddress(City<int, string, float> pl, string na, int co)
        {
            Address<int, string, float> ad = new Address<int, string, float>(pl, na, co);
            return ad;
        }

        static Address<int, string, float> MakeListAddress(int size)
        {
            if (size == 0) return null;
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Address<int, string, float> beg;
            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            if (rnd.Next(0, 2) == 1)
            {
                str = RandomWord();
                co = rnd.Next(1, 10);

                Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                beg = MakeAddress(mg, str, co);
            }
            else
            {
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                beg = MakeAddress(ct, str, co);
            }
            for (int i = 1; i < size; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Console.WriteLine("Элементы {0}, {1} и {2} добавляются...", str, co, sq);
                ct = MakeCity(ar, str, co, sq);
                Address<int, string, float> p;
                if (rnd.Next(0, 2) == 1)
                {
                    str = RandomWord();
                    co = rnd.Next(1, 10);

                    Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p = MakeAddress(mg, str, co);
                }
                else
                {
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p = MakeAddress(ct, str, co);
                }

                p.next = beg;
                beg = p;
            }
            return beg;
        }
        static Address<int, string, float> AddNext(Address<int, string, float> beg, int number)
        {
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Address<int, string, float> NewAddress;
            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            if (rnd.Next(0, 2) == 1)
            {
                str = RandomWord();
                co = rnd.Next(1, 10);

                Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                NewAddress = MakeAddress(mg, str, co);
            }
            else
            {
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                NewAddress = MakeAddress(ct, str, co);
            }
            if (beg is null)//список пустой
            {
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                Area<int, string, float> area = MakeArea(MakePlace(rnd.Next(-90, 91), rnd.Next(-180, 181)), str, co, sq);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                City<int, string, float> city = MakeCity(area, str, co, sq);
                if (rnd.Next(0, 2) == 1)
                {
                    str = RandomWord();
                    co = rnd.Next(1, 10);

                    Megapolis<int, string, float> mg = MakeMegapolice(city, str, co);
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    NewAddress = MakeAddress(mg, str, co);
                }
                else
                {
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    NewAddress = MakeAddress(city, str, co);
                }
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                NewAddress.next = beg;
                beg = NewAddress;
                return beg;
            }
            //вспом. переменная для прохода по списку
            Address<int, string, float> p = beg;
            //идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && !(p is null); i++)
                p = p.next;
            if (p is null)//элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше введенного числа!");
                return beg;
            }
            //добавляем новый элемент
            NewAddress.next = p.next;
            p.next = NewAddress;
            return beg;
        }
        static void ShowList(Address<int, string, float> beg)
        {
            //проверка наличия элементов в списке
            if (beg is null)
            {
                Console.WriteLine("Лист пуст");
                return;
            }
            Address<int, string, float> p = beg;
            while (!(p is null))
            {
                Console.Write(p + " ");
                p = p.next;//переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(Address<int, string, float> p)
        {
            if (!(p is null))
            {

                ShowTree(p.right);//переход к левому поддереву 
                ShowTree(p.left);//переход к правому поддереву
                Console.WriteLine(p);
            }
        }
        static Address<int, string, float> MakeListLRAddress(int num)
        {
            if (num == 0) return null;
            Random rnd = new Random();
            num--;
            int num1 = num / 2;
            int num2 = num - num1;
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = MakeArea(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            Address<int, string, float> beg;
            if (rnd.Next(0, 2) == 1)
            {
                str = RandomWord();
                co = rnd.Next(1, 10);

                Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                beg = MakeAddress(mg, str, co);
            }
            else
            {
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                beg = MakeAddress(ct, str, co);
            }
            Address<int, string, float> p = beg;
            for (int i = 1; i < num1 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                ct = MakeCity(ar, str, co, sq);
                
                if (rnd.Next(0, 2) == 1)
                {
                    str = RandomWord();
                    co = rnd.Next(1, 10);
                    Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p.left = MakeAddress(mg, str, co);
                }
                else
                {
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p.left = MakeAddress(ct, str, co);
                }
                p = p.left;
               
            }
            p = beg;
            for (int i = 1; i < num2 + 1; i++)
            {
                info1 = rnd.Next(-90, 91);
                info2 = rnd.Next(-180, 181);
                str = RandomWord();
                co = rnd.Next(0, 100);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                pl = MakePlace(info1, info2);
                ar = MakeArea(pl, str, co, sq);
                str = RandomWord();
                co = rnd.Next(100, 1000000);
                sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
                ct = MakeCity(ar, str, co, sq);

                if (rnd.Next(0, 2) == 1)
                {
                    str = RandomWord();
                    co = rnd.Next(1, 10);

                    Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p.right = MakeAddress(mg, str, co);
                }
                else
                {
                    str = RandomWord();
                    co = rnd.Next(1, 400);
                    Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                    p.right = MakeAddress(ct, str, co);
                }
                p = p.right;
            }
            return beg;
        }
        static Address<int, string, float> Delete(Address<int, string, float> beg, int number)
        {

            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return null;
            }
            if (number == 1)//удаляем первый элемент
            {
                beg = beg.right;
                return beg;
            }
            Address<int, string, float> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.right is null); i++)
                p = p.right;
            if (i < number - 1)
            {
                for (; i < number - 1 && !(p.left is null); i++)
                    p = p.left;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                return beg;
            }
            //исключаем элемент из списка
            if (!(p.right is null) && !(p.right.right is null))
                p.right = p.right.right;
            else if (!(p.right is null) && p.right.right is null && !(p.right.left is null))
                p.right = p.right.left;
            else if (!(p.left is null))
                p.left = p.left.left;
            else if (p.left is null && !(p is null))
                p = null;

            return beg;


        }

        static Address<int, string, float> IdealTree(int size, Address<int, string, float> p)
        {
            Address<int, string, float> r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            Random rnd = new Random();
            int info1 = rnd.Next(-90, 91);
            int info2 = rnd.Next(-180, 181);
            string str = RandomWord();
            int co = rnd.Next(0, 100);
            float sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;
            Place<int> pl = MakePlace(info1, info2);//создаем первый элемент
            Area<int, string, float> ar = new Area<int, string, float>(pl, str, co, sq);
            str = RandomWord();
            co = rnd.Next(100, 1000000);
            sq = (float)rnd.Next(0, 100) + (float)(rnd.Next(1, 999)) / 1000;

            City<int, string, float> ct = MakeCity(ar, str, co, sq);
            if (rnd.Next(0, 2) == 1)
            {
                str = RandomWord();
                co = rnd.Next(1, 10);

                Megapolis<int, string, float> mg = MakeMegapolice(ct, str, co);
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                r = MakeAddress(mg, str, co);
            }
            else
            {
                str = RandomWord();
                co = rnd.Next(1, 400);
                Console.WriteLine("Элементы {0}, {1} добавляются...", str, co);
                r = MakeAddress(ct, str, co);
            }
            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            return r;
        }
        static void Average(Address<int, string, float> p, ref int laA, ref int loA, ref int count)
        {
            if (!(p is null))
            {

                Average(p.left, ref laA, ref loA, ref count);
                laA += p.latitude;
                loA += p.longitude;
                count++;
                Average(p.right, ref laA, ref loA, ref count);
            }
        }
        static void CreationBinaryTree(Address<int, string, float> root, ref Address<int, string, float> binTree, bool first = true)
        {

            if (!(root is null))
            {
                if (first)
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    City<int, string, float> ct = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                    if (root.nameOfMegapolice != default)
                    {
                        Megapolis<int, string, float> mg = new Megapolis<int, string, float>(ct, root.nameOfMegapolice, root.countOfAglommeration);
                        binTree = new Address<int, string, float>(mg, root.streatName, root.numberOfStreat);
                    }
                    else
                    {
                        binTree = new Address<int, string, float>(ct, root.streatName, root.numberOfStreat);
                    }
                }
                else
                {
                    Place<int> pl = new Place<int>(root.latitude, root.longitude);
                    Area<int, string, float> ar = new Area<int, string, float>(pl, root.nameOfArea, root.countOfCity, root.squearOfArea);
                    City<int, string, float> ct = new City<int, string, float>(ar, root.nameOfCity, root.countOfPeople, root.squearOfCity);
                    Address<int, string, float> NewPoint;
                    if (root.nameOfMegapolice != default)
                    {
                        Megapolis<int, string, float> mg = new Megapolis<int, string, float>(ct, root.nameOfMegapolice, root.countOfAglommeration);
                        NewPoint = new Address<int, string, float>(mg, root.streatName, root.numberOfStreat);
                    }
                    else
                    {
                        NewPoint = new Address<int, string, float>(ct, root.streatName, root.numberOfStreat);
                    }
                    binTree = Add(binTree, NewPoint);
                }
                CreationBinaryTree(root.left, ref binTree, false);

                CreationBinaryTree(root.right, ref binTree, false);
            }

        }
        static Address<int, string, float> Add(Address<int, string, float> root, Address<int, string, float> NewPoint)
        {
            Address<int, string, float> p = root; //корень дерева
            Address<int, string, float> r = null;
            //флаг для проверки существования элемента d в дереве
            bool ok = false;
            while (!(p is null) && !ok)
            {
                r = p;
                //элемент уже существует
                if (NewPoint == p && NewPoint == p) ok = true;
                else
            if (NewPoint < p) p = p.left; //пойти в левое поддерево
                else p = p.right; //пойти в правое поддерево
            }
            if (ok) return p;//найдено, не добавляем
                             //создаем узел
                             //выделили память
                             // если d<r.key, то добавляем его в левое поддерево
            if (NewPoint < r) r.left = NewPoint;
            // если d>r.key, то добавляем его в правое поддерево
            else r.right = NewPoint;
            r = root;
            return r;
        }
        #endregion
    }

    public class Stack<T> : IEnumerable<T>, IEnumerator<T>, ICloneable
        where T : IComparable
    {
        public List<LRList<T>> _items = new List<LRList<T>>();
         LRList<T> current = new  LRList<T> ();
        int curItem = 0;
        public Stack()
        {
            _items = new List<LRList<T>>();
            current = new LRList<T>();
            curItem = 0;
        }
        public Stack(List<LRList<T>> add)
        {
            for(int i = 0; i< add.Count; i++)
            {
                _items.Add(add[i]);
            }
            current = _items[0];
            curItem = 0;
        }
        public int Count
        {
            get
            {
               return _items.Count;
            }
        }
        public void Push(LRList<T> item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _items.Add(item);
        }
        public void PushList(LRList<T>[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                _items.Add(item[i]);
            }
        }
        public LRList<T> Pop()
        {
            LRList<T> item = GetTopItem();
            _items.Remove(item);
            return item;
        }
        public LRList<T> Peek()
        {
            LRList<T> item = GetTopItem();
            return item;
        }
        public LRList<T> GetTopItem()
        {
            if (_items != null && _items.Count>0) 
            {
                LRList<T> item = _items[_items.Count - 1];
                if(item == null)
                    throw new ArgumentNullException(nameof(item));
                return item;
            }
            else if(_items.Count > 0)
            {
                return default;
            }
            else
            {
                throw new ArgumentNullException(nameof(_items));
            }
            
        }

        public LRList<T> Find(Place<T> find)
        {

            while (Count != 0)
            {
                LRList<T> ret = Pop();
                if (ret.Find(find.latitude, find.longitude) != null)
                {
                    return ret;
                }
            }
            return null;
             
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<LRList<T>> current = _items;
            for (int i = Count - 1; i >= 0; i--)
            {
                Place<T> curent = current[i].Root;
                while (!(curent is null))
                {
                    yield return curent.latitude;
                    curent = curent.left;
                }
                curent = current[i].Root.right;
                while (!(curent is null))
                {
                    yield return curent.latitude;
                    curent = curent.right;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (curItem < Count)
            {
                current = _items[curItem];
                return true;
            }
            else
            {
                current = _items[curItem];
                return false;
            }
        }

        public void Reset()
        {
            current = this._items[0];
            curItem = 0;
        }

        public void Dispose()
        {
            curItem = default;
            _items = null;
            current = null;
        }
        public Stack<T> ShallowCopy() //поверхностное копирование
        {
            return (Stack<T>)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Stack<T>(this._items);
        }



        public T Current
        {
            get
            {
                return current.Current;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
    public class LRList<T> : IEnumerable<T>, IEnumerator<T>, ICloneable 
        where T : IComparable
    {
        Place<T> current = new Place<T>();
        Place<T> root = new Place<T>();

        public int Count { get; private set; }
        public Place<T> Root
        {
            get
            {
                return root;
            }

        }

        public T Current 
        {
            get 
            {
                return current.longitude;
            }
        }

        object IEnumerator.Current 
        {
            get
            {
                return Current;
            }
        }
        public LRList(Place<T> rt, int cnt, Place<T> crt)
        {
            root = rt;
            Count = cnt;
            current = crt;
        }
        public LRList(params Place<T>[] arr1)
        {
            root = new Place<T>(arr1[0].latitude, arr1[0].longitude);
            current = root;//первый элемент
            int i = 1;
            for (; i < arr1.Length / 2; i++)
            {
                AddL(root, arr1[i].latitude, arr1[i].longitude);
                Count++;
            }
            for (; i < arr1.Length; i++)
            {
                AddR(root, arr1[i].latitude, arr1[i].longitude);
                Count++;
            }

        }
        public LRList(int capacity)
        {
            root = new Place<T>();
            current = root;//первый элемент
            for (int i = 1; i < capacity / 2; i++)
            {
                AddNullR(root);
                Count++;
            }
            for (int i = 1; i < capacity / 2; i++)
            {
                AddNullL(root);
                Count++;
            }
        }
        public LRList(LRList<T> c)
        {
            LRList<T> tree = new LRList<T>();
            tree = c;
            current = tree.root;
            AddR(root, tree.root.latitude, tree.root.longitude);
            tree.root = tree.root.left;
            while (true)
            {
                if (tree.root != null)
                {
                    AddL(root, tree.root.latitude, tree.root.longitude);
                    tree.root = tree.root.left;

                }
                else
                {
                    break;
                }
            }
            tree.root = c.root.right;
            while (true)
            {
                if (tree.root != null)
                {
                    AddR(root, tree.root.latitude, tree.root.longitude);
                    tree.root = tree.root.right;
                }
                else
                {
                    break;
                }
            }
        }
        public LRList()
        {
            root = null;
            Count = default;
            current = null;
        }
        public void Add(Place<T> value)
        {
            if(root is null)
            {
                root = value;
                return;
            }
            Place<T> current = root; 
            if (Count%2 == 0)
            {
                while (!(current.left is null))
                {
                    current = current.left;
                }
                current.left = value;
            }
            else
            {
                while (!(current.right is null))
                {
                    current = current.right;
                }
                current.right = value;
            }
            Count++;
        }
        public void AddList(Place<T>[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (root is null)
                {
                    root = value[i];
                    return;
                }
                Place<T> current = root;
                if (Count % 2 == 0)
                {
                    while (current.left != null)
                    {
                        current = current.left;
                    }
                    current.left = value[i];
                }
                else
                {
                    while (current.right != null)
                    {
                        current = current.right;
                    }
                    current.right = value[i];
                }
                Count++;
            }
        }
        public void Remove(int number)
        {
            Place < T > beg = (Place < T > )this.Root.Clone();
            if (beg is null)//пустой список
            {
                Console.WriteLine("Error! The List is empty");
                return;
            }
            
            if (Count == 1)//удаляем первый элемент
            {
                    root = null;
                    return;
            }
            Place<T> p = beg;
            int i = 1;
            //ищем элемент для удаления и встаем на предыдущий
            for (; i < number - 1 && !(p.left is null); i++)
                p = p.left;
            if (i < number - 1)
            {
                p = beg;
                for (; i < number - 1 && !(p.right is null); i++)
                    p = p.right;
            }
            if (p is null)//если элемент не найден
            {
                Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                root = beg;
            }
            //исключаем элемент из списка
            if (!(p.left is null) && !(p.right is null))
            {
                if (number % 2 == 0)
                {
                    p.left = p.left.left;
                }
                else
                {
                    p.right = p.right.right;
                }
            }
            else if (!(p.left is null) && p.right is null)
                p.left = p.left.left;

            else if (!(p.right is null))
                p.right = p.right.right;
            else if (p.left is null && !(p is null))
                p = null;
            root = beg;

        }
        public void RemoveList(Place<T>[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (root is null)//пустой список
                {
                    Console.WriteLine("Error! The List is empty");
                    break;
                }
                if (Count == 1)//удаляем первый элемент
                {
                    if (root == value[i])
                    {
                        root = null;
                        continue;
                    }
                }
                Place<T> current = root;
                bool found = false;
                //ищем элемент для удаления и встаем на предыдущий
                while (current.left != null)
                {
                    if (current == value[i])
                    {
                        found = true;
                        break;
                    }
                    current = current.left;
                }
                if (!found)
                {
                    current = root;
                    while (current.left != null)
                    {
                        if (current == value[i])
                        {
                            found = true;
                            break;
                        }
                        current = current.right;
                    }
                }
                if (current is null)//если элемент не найден
                {
                    Console.WriteLine("Ошибка! Размер листа меньше чем число!");
                    continue;
                }
                //исключаем элемент из списка
                if (!(current.right is null) && !(current.right.right is null))
                    current.right = current.right.right;
                else if (!(current.right is null) && !(current.right.right is null) && !(current.right.left is null))
                    current.right = current.right.left;
                else if (!(current.left is null))
                    current.left = current.left.left;
                else if (current.left is null && !(current is null))
                    current = null;
            }
        }
        public int Find(T la, T lo)
        {
            Place<T> current = root;
            int i = 1;
            while (!(current is null)) 
            { 
                if (current.latitude.Equals(la) && current.longitude.Equals(lo))
                {
                    return i;
                }
                i++;
                current = current.left;
            }
            current = root.right;
            while (!(current is null))
            {
                if (current.latitude.Equals(la) && current.longitude.Equals(lo))
                {
                    return i;
                }
                i++;
                current = current.right;
            }
            return -1;
        }


        static void AddL(Place<T> root, T la, T lo)
        {
            Place<T> p = root;
            while (true)
            {
                if (!(p is null))
                {
                    p = p.left;
                }
                else
                {
                    p = new Place<T>(la, lo);
                    break;
                }
            }
            p.left = root;
            root = p;

        }
        static void AddR(Place<T> root, T la, T lo)
        {
            Place<T> p = root;
            while (true)
            {
                if (!(p is null))
                {
                    p = p.right;
                }
                else
                {
                    p = new Place<T>(la, lo);
                    break;
                }
            }
            p.right = root;
            root = p;

        }
        static void AddNullR(Place<T> root)
        {
            Place<T> p = root;
            while (true)
            {
                if (!(p is null))
                {
                    p = p.right;
                }
                else
                {
                    p = new Place<T>();
                    break;
                }
            }
            p.right = root;
            root = p;

        }
        static void AddNullL(Place<T> root)
        {
            Place<T> p = root;
            while (true)
            {
                if (!(p is null))
                {
                    p = p.left;
                }
                else
                {
                    p = new Place<T>();
                    break;
                }
            }

            p.left = root;
            root = p;
        }


         

        public void Show()
        {
            if (root is null)
            {
                Console.WriteLine("Empty");
            }
            else
                root.Show();

        }

        public IEnumerator<T> GetEnumerator()
        {
            Place<T> current = root;
            while (!(current is null))
            {
                yield return current.latitude;
                current = current.left;
            }
            current = root.right;
            while (!(current is null))
            {
                yield return current.latitude;
                current = current.right;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if(current.left is null)
            {
                Reset();
                return true;
            }
            else if(current.left is null)
            {
                Reset();
                return false;
            }
            else if(!(current.left is null))
            {
                current = current.left;
                return true;
            }
            else
            {
                current = current.right;
                return true;
            }
        }

        public void Reset()
        {
            current = this.root;
        }

        public void Dispose()
        {
            Count = default;
            root = null;
            current = null; 
        }
        public LRList<T> ShallowCopy() //поверхностное копирование
        {
            return (LRList<T>)this.MemberwiseClone();
        } 

        public object Clone()
        {
            return new LRList<T>((Place<T>)this.root.Clone(), this.Count, this.current);
        }
    }

    public class Place<T> : ICloneable
        where T : IComparable

    {
        public T latitude,
              longitude;
       

        public Place<T> next, left, right;

        

        public Place(T la, T lo, Place<T> l = null, Place<T> r = null)
        {
            latitude = la;
            longitude = lo;
            next = null;
            left = l;
            right = r;
        }
        public Place()
        {
            latitude = default(T);
            longitude = default(T);
            next = null;
            left = null;
            right = null;

        }
        public void Show()
        {
            Console.WriteLine($"Координаты места: Ш.{latitude}°, Д.{longitude}°");
        }
        public override string ToString()
        {
            return "Координаты: " + latitude + " " + longitude + " ";
        }
        public static bool operator >(Place<T> first, Place<T> second)
        {
            if (first is null)
            {
                return false;
            }
            if (second is null)
            {
                return true;
            }
            if (first.latitude.CompareTo(second.latitude) == 0)
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }
            else if (first.latitude.CompareTo(second.latitude) > 0)
            {
                return true;
            }
            else
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }



        }
        public static bool operator <(Place<T> first, Place<T> second)
        {
            if (first == second)
            {
                return false;
            }
            return !(first > second);

        }
        public static bool operator ==(Place<T> first, Place<T> second)
        {
            if (first is null || second is null)
                return false;
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Place<T> first, Place<T> second)
        {
            if (first is null || second is null)
                return false;
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return false;
            }
            return true;

        }
        public object Clone()
        {
            return new Place<T>(this.latitude, this.longitude, this.left, this.right);
        }
        public Place<T> ShallowCopy() //поверхностное копирование
        {
            return (Place<T>)this.MemberwiseClone();
        }
    }
    public class Area<Ti, Ts, Tf> : Place<Ti>
        where Ti : IComparable
        where Ts : IComparable
        where Tf : IComparable
    {
        public Ts nameOfArea;
        public Ti countOfCity;
        public Tf squearOfArea;

        public Area<Ti, Ts, Tf> next, left, right;

        public Area(Place<Ti> place, Ts name, Ti count, Tf square, Area<Ti, Ts, Tf> l = null, Area<Ti, Ts, Tf> r = null)
        {
            left = l;
            right = r;
            longitude = place.longitude;
            latitude = place.latitude;
            nameOfArea = name;
            countOfCity = count;
            squearOfArea = square;
            next = null;

        }
        public Area()
        {
            longitude = default(Ti);
            latitude = default(Ti);
            nameOfArea = default(Ts);
            countOfCity = default(Ti);
            squearOfArea = default(Tf);
            next = null;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return nameOfArea + " " + countOfCity + " " + squearOfArea;
        }
        public static bool operator >(Area<Ti, Ts, Tf> first, Area<Ti, Ts, Tf> second)
        {

            if (first.latitude.CompareTo(second.latitude) == 0)
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }
            else if (first.latitude.CompareTo(second.latitude) > 0)
            {
                return true;
            }
            else
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }



        }
        public static bool operator <(Area<Ti, Ts, Tf> first, Area<Ti, Ts, Tf> second)
        {
            if (first == second)
            {
                return false;
            }
            return !(first > second);

        }
        public static bool operator ==(Area<Ti, Ts, Tf> first, Area<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Area<Ti, Ts, Tf> first, Area<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return false;
            }
            return true;

        }

        public Area<Ti, Ts, Tf> ShallowCopy() //поверхностное копирование
        {
            return (Area<Ti, Ts, Tf>)this.MemberwiseClone();
        }
        public object Clone()
        {
            Place<Ti> clone = new Place<Ti>(this.latitude, this.longitude, this.left, this.right);
            return new Area<Ti, Ts, Tf>(clone, this.nameOfArea, this.countOfCity, this.squearOfArea, this.left, this.right);
        }
    }
    public class City<Ti, Ts, Tf> : Area<Ti, Ts, Tf>
        where Ti : IComparable
        where Ts : IComparable
        where Tf : IComparable
    {
        public Ts nameOfCity;
        public Ti countOfPeople;
        public Tf squearOfCity;

        public City<Ti, Ts, Tf> next, left, right;

        public City(Area<Ti, Ts, Tf> place, Ts name, Ti count, Tf squear, City<Ti, Ts, Tf> l = null, City<Ti, Ts, Tf> r = null)
        {
            left = l;
            right = r;
            longitude = place.longitude;
            latitude = place.latitude;
            nameOfArea = place.nameOfArea;
            countOfCity = place.countOfCity;
            squearOfArea = place.squearOfArea;
            nameOfCity = name;
            countOfPeople = count;
            squearOfCity = squear;
            next = null;
        }
        public City()
        {

            longitude = default(Ti);
            latitude = default(Ti);
            nameOfArea = default(Ts);
            countOfCity = default(Ti);
            squearOfArea = default(Tf);
            nameOfCity = default(Ts);
            countOfPeople = default(Ti);
            squearOfCity = default(Tf);
            next = null;
            left = null;
            right = null;
        }

        public override string ToString()
        {
            return nameOfCity + " " + countOfPeople + " " + squearOfCity;
        }
        public static bool operator >(City<Ti, Ts, Tf> first, City<Ti, Ts, Tf> second)
        {

            if (first.latitude.CompareTo(second.latitude) == 0)
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }
            else if (first.latitude.CompareTo(second.latitude) > 0)
            {
                return true;
            }
            else
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }



        }
        public static bool operator <(City<Ti, Ts, Tf> first, City<Ti, Ts, Tf> second)
        {
            if (first == second)
            {
                return false;
            }
            return !(first > second);

        }
        public static bool operator ==(City<Ti, Ts, Tf> first, City<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(City<Ti, Ts, Tf> first, City<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return false;
            }
            return true;

        }
        public City<Ti, Ts, Tf> ShallowCopy() //поверхностное копирование
        {
            return (City<Ti, Ts, Tf>)this.MemberwiseClone();
        }
        public object Clone()
        {
            Place<Ti> clone = new Place<Ti>(this.latitude, this.longitude, this.left, this.right);
            Area<Ti, Ts, Tf> clone1 = new Area<Ti, Ts, Tf>(clone, this.nameOfArea, this.countOfCity, this.squearOfArea, this.left, this.right);
            return new City<Ti, Ts, Tf>(clone1, this.nameOfCity, this.countOfPeople, this.squearOfCity, this.left, this.right);
        }
    }
    public class Megapolis<Ti, Ts, Tf> : City<Ti, Ts, Tf>
        where Ti : IComparable
        where Ts : IComparable
        where Tf : IComparable
    {
        public Ti countOfAglommeration = default(Ti);
        public Ts nameOfMegapolice = default(Ts);
        public Megapolis<Ti, Ts, Tf> next, left, right;

        public Megapolis(City<Ti, Ts, Tf> place, Ts name, Ti count, Megapolis<Ti, Ts, Tf> l = null, Megapolis<Ti, Ts, Tf> r = null)
        {
            left = l;
            right = r;
            nameOfMegapolice = name;
            countOfAglommeration = count;
            longitude = place.longitude;
            latitude = place.latitude;
            nameOfArea = place.nameOfArea;
            countOfCity = place.countOfCity;
            squearOfArea = place.squearOfArea;
            nameOfCity = place.nameOfCity;
            countOfPeople = place.countOfPeople;
            squearOfCity = place.squearOfCity;
            next = null;
        }


        public Megapolis()
        {
            countOfAglommeration = default(Ti);
            nameOfMegapolice = default(Ts);
            longitude = default(Ti);
            latitude = default(Ti);
            nameOfArea = default(Ts);
            countOfCity = default(Ti);
            squearOfArea = default(Tf);
            nameOfCity = default(Ts);
            countOfPeople = default(Ti);
            squearOfCity = default(Tf);
            next = null;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return nameOfMegapolice + " " + countOfAglommeration;
        }
        public static bool operator >(Megapolis<Ti, Ts, Tf> first, Megapolis<Ti, Ts, Tf> second)
        {

            if (first.latitude.CompareTo(second.latitude) == 0)
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }
            else if (first.latitude.CompareTo(second.latitude) > 0)
            {
                return true;
            }
            else
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }



        }
        public static bool operator <(Megapolis<Ti, Ts, Tf> first, Megapolis<Ti, Ts, Tf> second)
        {
            if (first == second)
            {
                return false;
            }
            return !(first > second);

        }
        public static bool operator ==(Megapolis<Ti, Ts, Tf> first, Megapolis<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Megapolis<Ti, Ts, Tf> first, Megapolis<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return false;
            }
            return true;

        }
        public Megapolis<Ti, Ts, Tf> ShallowCopy() //поверхностное копирование
        {
            return (Megapolis<Ti, Ts, Tf>)this.MemberwiseClone();
        }
        public object Clone()
        {
            Place<Ti> clone = new Place<Ti>(this.latitude, this.longitude, this.left, this.right);
            Area<Ti, Ts, Tf> clone1 = new Area<Ti, Ts, Tf>(clone, this.nameOfArea, this.countOfCity, this.squearOfArea, this.left, this.right);
            City<Ti, Ts, Tf> clone2 = new City<Ti, Ts, Tf>(clone1, this.nameOfCity, this.countOfPeople, this.squearOfCity, this.left, this.right);
            return new Megapolis<Ti, Ts, Tf>(clone2, this.nameOfMegapolice, this.countOfAglommeration, this.left, this.right);
        }
    }
    public class Address<Ti, Ts, Tf> : Megapolis<Ti, Ts, Tf>
        where Ti : IComparable
        where Ts : IComparable
        where Tf : IComparable
    {
        public Ts streatName;
        public Ti numberOfStreat;
        public Address<Ti, Ts, Tf> next, left, right;

        public Address(Megapolis<Ti, Ts, Tf> place, Ts name, Ti num, Address<Ti, Ts, Tf> l = null, Address<Ti, Ts, Tf> r = null)
        {
            left = l;
            right = r;

            streatName = name;
            numberOfStreat = num;
            nameOfMegapolice = place.nameOfMegapolice;
            countOfAglommeration = place.countOfAglommeration;
            longitude = place.longitude;
            latitude = place.latitude;
            nameOfArea = place.nameOfArea;
            countOfCity = place.countOfCity;
            squearOfArea = place.squearOfArea;
            nameOfCity = place.nameOfCity;
            countOfPeople = place.countOfPeople;
            squearOfCity = place.squearOfCity;
            next = null;
        }
        public Address(City<Ti, Ts, Tf> place, Ts name, Ti num, Address<Ti, Ts, Tf> l = null, Address<Ti, Ts, Tf> r = null)
        {
            left = l;
            right = r;
            streatName = name;
            numberOfStreat = num;
            nameOfMegapolice = default(Ts);
            countOfAglommeration = default(Ti);
            longitude = place.longitude;
            latitude = place.latitude;
            nameOfArea = place.nameOfArea;
            countOfCity = place.countOfCity;
            squearOfArea = place.squearOfArea;
            nameOfCity = place.nameOfCity;
            countOfPeople = place.countOfPeople;
            squearOfCity = place.squearOfCity;
            next = null;
        }
        public Address()
        {
            streatName = default(Ts);
            numberOfStreat = default(Ti);
            countOfAglommeration = default(Ti);
            nameOfMegapolice = default(Ts);
            longitude = default(Ti);
            latitude = default(Ti);
            nameOfArea = default(Ts);
            countOfCity = default(Ti);
            squearOfArea = default(Tf);
            nameOfCity = default(Ts);
            countOfPeople = default(Ti);
            squearOfCity = default(Tf);
            next = null;
            left = null;
            right = null;
        }

        public override string ToString()
        {
            return streatName + " " + numberOfStreat;
        }
        public static bool operator >(Address<Ti, Ts, Tf> first, Address<Ti, Ts, Tf> second)
        {

            if (first.latitude.CompareTo(second.latitude) == 0)
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }
            else if (first.latitude.CompareTo(second.latitude) > 0)
            {
                return true;
            }
            else
            {
                if (first.longitude.CompareTo(second.longitude) == 0)
                    return false;
                if (first.longitude.CompareTo(second.longitude) > 0)
                    return true;
                return false;
            }



        }
        public static bool operator <(Address<Ti, Ts, Tf> first, Address<Ti, Ts, Tf> second)
        {
            if (first == second)
            {
                return false;
            }
            return !(first > second);

        }
        public static bool operator ==(Address<Ti, Ts, Tf> first, Address<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Address<Ti, Ts, Tf> first, Address<Ti, Ts, Tf> second)
        {
            if (first.latitude.Equals(second.latitude) && first.longitude.Equals(second.longitude))
            {
                return false;
            }
            return true;

        }
        public Address<Ti, Ts, Tf> ShallowCopy() //поверхностное копирование
        {
            return (Address<Ti, Ts, Tf>)this.MemberwiseClone();
        }
        public object Clone()
        {
            Place<Ti> clone = new Place<Ti>(this.latitude, this.longitude, this.left, this.right);
            Area<Ti, Ts, Tf> clone1 = new Area<Ti, Ts, Tf>(clone, this.nameOfArea, this.countOfCity, this.squearOfArea, this.left, this.right);
            City<Ti, Ts, Tf> clone2 = new City<Ti, Ts, Tf>(clone1, this.nameOfCity, this.countOfPeople, this.squearOfCity, this.left, this.right);
            Megapolis < Ti, Ts, Tf > clone3 = new Megapolis<Ti, Ts, Tf>(clone2, this.nameOfMegapolice, this.countOfAglommeration, this.left, this.right);
            return new Address<Ti, Ts, Tf>(clone3, this.streatName, this.numberOfStreat, this.left, this.right);
        }
    } 
}

