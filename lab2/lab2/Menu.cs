using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Menu
    {
        private Picture p;

        public Menu()
        {
            p = new Picture();
            RightTriangle t1 = new RightTriangle(5, 7, 0.26);
            IsoscelesTriangle t2 = new IsoscelesTriangle(3, 0.14);
            EquilateralTriangle t3 = new EquilateralTriangle(6);
            EquilateralTriangle t4 = new EquilateralTriangle(6);
            EquilateralTriangle t5 = new EquilateralTriangle(2);
            IsoscelesTriangle t6 = new IsoscelesTriangle(8, 0.79);
            RightTriangle t7 = new RightTriangle(2, 3, 1.15);
            p.Add(t1);
            p.Add(t2);
            p.Add(t3);
            p.Add(t4);
            p.Add(t5);
            p.Add(t6);
            p.Add(t7);
            // Console.WriteLine(p.ToString());
        }

        public void DisplayMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine("==================================");
            Console.WriteLine("0)Выход");
            Console.WriteLine("1)Вывести содержимое коллекции");
            Console.WriteLine("2)Перегруженый оператор +");
            Console.WriteLine("3)Перегруженый метод Equals()");
            Console.WriteLine("4)Перегруженый оператор ==");
            Console.WriteLine("5)Перегруженый метод GetHashCode()");
            Console.WriteLine("6)Перегруженый метод ToString()");
            Console.WriteLine("7)События");
            Console.WriteLine("8)Стандартное исключение");
            Console.WriteLine("9)Пользовательское исключение");
            Console.WriteLine("==================================");
        }

        public void ProcessSelectedItem()
        {
            for (;;)
            {

                DisplayMenu();
                if (!int.TryParse(Console.ReadLine(), out int i) || ((i < 0) && (i > 9)))
                {
                    Console.Clear();
                    Console.WriteLine("Нажмите клавишу от 0 до 9");
                }
                else
                {
                    Console.Clear();
                    switch (i)
                    {
                        case 0: { break; }
                        case 1:
                            {
                                Console.WriteLine("Содержимое коллекции:");
                                Console.WriteLine(p.ToString());
                                break;
                            }
                        case 2: {
                                RightTriangle t1 = new RightTriangle(5, 7, 0.26);
                                IsoscelesTriangle t2 = new IsoscelesTriangle(3, 0.14);
                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1);
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2);
                                Console.WriteLine("Сумма:");
                                Console.WriteLine(t1+t2);
                                break;
                            }
                        case 3:
                            {
                                IsoscelesTriangle t1 = new IsoscelesTriangle(5, 1.04719755);
                                EquilateralTriangle t2 = new EquilateralTriangle(5);
                                IsoscelesTriangle t3 = new IsoscelesTriangle(5, 1.04719755);
                                IsoscelesTriangle t4 = new IsoscelesTriangle(3, 0.14);

                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1);
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2);
                                Console.WriteLine("Третий параметр:");
                                Console.WriteLine(t3);
                                Console.WriteLine("Четвертый параметр:");
                                Console.WriteLine(t4);
                                Console.WriteLine("Первый.Equals(Второй) :"+ (t1.Equals(t2)));
                                Console.WriteLine("Первый.Equals(Третий) :"+ (t1.Equals(t3)));
                                Console.WriteLine("Первый.Equals(Четвёртый) :" + (t1.Equals(t4)));
                                break;
                            }
                        case 4:
                            {
                                IsoscelesTriangle t1 = new IsoscelesTriangle(5, 1.04719755);
                                EquilateralTriangle t2 = new EquilateralTriangle(5);
                                IsoscelesTriangle t3 = new IsoscelesTriangle(5, 1.04719755);
                                IsoscelesTriangle t4 = new IsoscelesTriangle(3, 0.14);

                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1);
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2);
                                Console.WriteLine("Третий параметр:");
                                Console.WriteLine(t3);
                                Console.WriteLine("Четвертый параметр:");
                                Console.WriteLine(t4);
                                Console.WriteLine("Первый == Второй :" + (t1 == t2));
                                Console.WriteLine("Первый == Третий :" + (t1 == t3));
                                Console.WriteLine("Первый == Четвёртый :" + (t1 == t4));
                                break;
                            }
                        case 5:
                            {
                                IsoscelesTriangle t1 = new IsoscelesTriangle(5, 1.04719755);
                                EquilateralTriangle t2 = new EquilateralTriangle(5);
                                IsoscelesTriangle t3 = new IsoscelesTriangle(5, 1.04719755);
                                IsoscelesTriangle t4 = new IsoscelesTriangle(3, 0.14);

                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1);
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2);
                                Console.WriteLine("Третий параметр:");
                                Console.WriteLine(t3);
                                Console.WriteLine("Четвертый параметр:");
                                Console.WriteLine(t4);
                                Console.WriteLine("Первый.GetHashCode():" + (t1.GetHashCode()));
                                Console.WriteLine("Второй.GetHashCode():" + (t2.GetHashCode()));
                                Console.WriteLine("Третий.GetHashCode():" + (t3.GetHashCode()));
                                Console.WriteLine("Четвертый.GetHashCode():" + (t4.GetHashCode()));
                                break;
                            }
                        case 6: {
                                RightTriangle t1 = new RightTriangle(5, 7, 0.26);
                                IsoscelesTriangle t2 = new IsoscelesTriangle(3, 0.14);
                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1.ToString());
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2.ToString());
                                break;
                            }
                        case 7: {
                                Handler handler = new Handler();
                                p.onAdd += handler.ShowMessage;
                                p.onRemove += handler.ShowMessage;
                                RightTriangle t1 = new RightTriangle(5, 7, 0.26);
                                IsoscelesTriangle t2 = new IsoscelesTriangle(3, 0.14);
                                Console.WriteLine("Первый параметр:");
                                Console.WriteLine(t1);
                                Console.WriteLine("Второй параметр:");
                                Console.WriteLine(t2);
                                Console.WriteLine("Добавление элементов в коллекцию:");
                                p.Add(t1);
                                p.Add(t2);
                                Console.WriteLine("Удаление из коллекции с позиции 0 и 1:");
                                p.RemoveAt(0);
                                p.RemoveAt(1);
                                p.onAdd -= handler.ShowMessage;
                                p.onRemove -= handler.ShowMessage;
                                break;
                            }
                        case 8: {
                                Console.WriteLine("Попытка удаления элемента с несуществующей позиции:");
                                p.RemoveAt(1000);
                                Console.WriteLine();
                                break;
                            }
                        case 9: {
                                Console.WriteLine("Попытка создания элемента с отрицательными сторонами:");
                                EquilateralTriangle t1 = new EquilateralTriangle(-5);
                                Console.WriteLine();
                                break;
                            }
                    }

                    if (i == 0) break;

                }

            }



        }
    }
}
