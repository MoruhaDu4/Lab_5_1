namespace Lab_5_1
{
    internal class Program
    {
        abstract class Parent
        {
            protected double a;
            protected double d;
            protected int n;

            public Parent(double a, double d, int n)
            {
                this.a = a;
                this.d = d;
                this.n = n;
            }

            public abstract string Info();

            public abstract double Metod1();

            public abstract double Metod2();
        }

        class Child1 : Parent
        {
            public Child1(double a, double d, int n) : base(a, d, n)
            {
            }

            public override string Info()
            {
                return $"Арифметична прогресiя: перший член = {a}, рiзниця = {d}, кiлькiсть членiв = {n}";
            }

            public override double Metod1()
            {
                return a + (n - 1) * d;
            }

            public override double Metod2()
            {
                return (n * (2 * a + (n - 1) * d)) / 2;
            }
        }

        class Child2 : Parent
        {
            public Child2(double a, double d, int n) : base(a, d, n)
            {
            }

            public override string Info()
            {
                return $"Геометрична прогресiя: перший член = {a}, знаменник = {d}, кiлькiсть членiв = {n}";
            }

            public override double Metod1()
            {
                return a * Math.Pow(d, n - 1);
            }

            public override double Metod2()
            {
                return a * (1 - Math.Pow(d, n)) / (1 - d);
            }
        }


        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
                {
                    double a = random.Next(1, 11); 
                    double d = random.Next(1, 6);  
                    int n = random.Next(5, 11);    
                    int x = random.Next(2);        

                    Parent progression;

                    if (x == 0)
                    {
                        progression = new Child1(a, d, n);
                    }
                    else
                    {
                        progression = new Child2(a, d, n);
                    }

                    Console.WriteLine(progression.Info());
                    Console.WriteLine($"n-й елемент: {progression.Metod1()}");
                    Console.WriteLine($"Сума перших n елементв: {progression.Metod2()}");
                    Console.WriteLine();
                }
            }
        }
    }


