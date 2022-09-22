using System;
using System.Collections.Generic;

namespace ProjectOne
{
    /*
    class Program
    {
        static void Main(string[] args) // метод Main
        {
            Console.WriteLine("Привет\nКонстянчик" );
            Console.ReadKey();
        }
    }
    */
    //ПЕРЕМЕННЫЕ
    /*
    class MainClass
    {
        public static void Main (string[] args)
        {
            int num, num1;
            Console.WriteLine("Введите первое число:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите второе число:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nКонечный результат: " + (num * num1).ToString());
            Console.ReadKey();
        }   
    }
    */
    // КОНСТАНТЫ 
    /*
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;
            const float score = 2.35f;
            score = 2.35f;

            num = num + 1;
            num++;
            num--;
        }
    }
    */
    // УСЛОВНЫЕ ОПЕРАТОРЫ
    /*
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Сколько тебе лет? ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 18.28d && num < 45)
            {
                Console.WriteLine("ОГО");
             } 
            else if (num < 15)
                { 
                    Console.WriteLine("ТА ТЫ ЕЩЕ КОЗЯВКА");
                }
            else
                {
                    Console.WriteLine("ЧТО?");
                }
            string name = num == 15 ? "First" : "Second";
            Console.WriteLine(name);
            Console.ReadKey(); 
            
        }
    }
    */
    // ОПЕРАТОР SWITCH
    /*
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randNum = new Random();
            int num;
            num = randNum.Next (1, 6);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Num is - " + num);
                    break;
                case 2:
                    Console.WriteLine("Num is equal to " + num);
                    break;
                default:
                    Console.WriteLine("Nothing " + num);
                    break;
            }
            Console.ReadKey();
        }
    }
    */
    // ЦИКЛЫ
    /* class MainClass
     {
         public static void Main(string[] args)
         {
             //           for (int i = 0;  i<5; i+= 2)
             //           {
             //               Console.WriteLine(i + "\n");
             //            }
             /*int i = 100;
             while (i >=60)
             {
                 Console.WriteLine(i);
                 i/=5;
             }*/
    /*            int number;
                do
                {
                    Console.WriteLine("Enter number ");
                    number = Convert.ToInt32(Console.ReadLine());
                }while (number !=5) ;
                Console.ReadKey();
            */
    /* for (int i = 10; i >= 5; i -= 1)
     {
         if (i < 8)
             break; //continue
         Console.WriteLine(i + "\n");
     }
         }
    }*/
    //МАССИВЫ
    // class MainClass
    //{
    // public static void Main(string[] args)
    //{
    //List<int> numbers = new List<int>();
    //numbers.Add(23);
    //numbers.Add(56);
    //numbers.Remove(56);
    // Console.WriteLine( numbers [1]);
    // string[] names = new string[3]
    // {
    //     "TOM", "JONH", "GEORGE"
    //};

    /* int[] array = new int[5];
     array[0] = 24;
     array[1] = 4;
     array[2] = 2;
     array[3] = 7;
     array[4] = 58;
     */
    //int[,] numbers = new int[5, 5];
    // numbers[1,2] = 23;
    // Console.Write(numbers[1, 2]);
    //for (int i = 0; i < numbers.Count; i++) 
    // Console.Write(numbers[i] + ",");

    // ЦИКЛ FOREACH
    /* float[] numbers = { 1.23f, 23.23f, 23.57f };
     foreach ( float el in numbers)
     {
         Console.WriteLine(el);

     }
     Console.ReadKey();
    */

    //МЕТОДЫ И ФУНКЦИИ

    /*  WriteHello("HI!");
      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      int result = Multiply(num1, num2);
      Console.WriteLine("Result is - " + result);
      Console.ReadKey();
      //Multiply(num1, num2);
     // Console.ReadLine();
  }
      public static void  WriteHello (string str)
  {
      Console.WriteLine(str);
  }
  public static int Multiply(int num1, int num2)
  {
      return num1 * num2;
  }*/

    //Работа со строками

    /*string str = "яблоко, груша, киви"  ;
    //Console.WriteLine(String.IsNullOrWhiteSpace(str));

    //String.Compare("a", "b"); // вернет -1
    //Console.WriteLine(str.ToLower());
    //Console.WriteLine(str.Contains("llo"));
    //Console.WriteLine(str.ToUpper());
    //Console.WriteLine(str.StartsWith("Hell"));
    //Console.WriteLine(str.EndsWith("lD"));
    //Console.WriteLine(str.Insert(5,"lD"));
    //Console.WriteLine(str.Remove(5));
    char[] sym = str.ToCharArray();
    string[] clubs = str.Split(',');
    Console.WriteLine(clubs[1]);
    */

    //Оператор try-catch

    /*Console.WriteLine("Enter number: ");
    try
    {
        int num = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Num is - " + num);
        //return false;
    }
    catch (FormatException )
    {
        Console.WriteLine("Format Exception");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("IndexOutOfRangeException");
    }
    finally
    {

    }*/
    //  }
    //}
    // СОЗДАНИЕ КЛАССОВ
    // Указатель this
    /* class Animal
     {
         public static int count; //= 0;
         public string name; //= "Spotty";
         public int age; //= 7;
         public float hapiness; //= 0.6f;

         public Animal ()
             {
             name = "Spotty";
             age = 7;
             hapiness = 0.7f;

             count++;
             Print();
             }

         public Animal (string name, int age, float hapiness)
         {
             this.name = name;
             this.age = age;
             this.hapiness = hapiness;

             count++;
             Print();
         }

         public void Print()
         {
             Console.WriteLine("Name: " + name);
             Console.WriteLine("Age: " + age);
             Console.WriteLine("Hapiness: " + hapiness);

         }
     }
     class MainClass
     {
         public static void Main(string[] args)
         {
             Animal cat = new Animal();
             Console.WriteLine();
             Animal dog = new Animal("Tom", 12 ,0.99f);
             Console.WriteLine("Count of animals: " + Animal.count);


         }
     }*/
    /*class Student
     {
         private string name;
         private int course;
         private bool stipuha;

         /*public int Course
         {
             get
             {
                 return course;
             }
             set
             {
                 if (value < 1)
                     course = 1;
                 else if (value > 5)
                     course = 5;
                 else
                     course = value;
             }
         }

         public int Course { get; set; }

         public Student()
         {
             name = "Alex";
             course = 2;
             stipuha = true;

             PrintAll(); 
         }
         public void PrintAll ()
         {
             Console.WriteLine("Name: " + name);
             Console.WriteLine("Course: " + course);
             Console.WriteLine("Stipuha: " + stipuha);
         }

         class MainClass
         {
             public static void Main (string [] args)
             {
                 Student Alex = new Student();
                 Alex.Course =6;
                 Console.WriteLine(Alex.Course);
             }
         }
     }*/
    // НАСЛЕДОВАНИЕ 
    // Операторы is и as. Массив указателей
    //Виртуальные методы
    //Абстрактные классы, методы и свойства
    /*abstract class Animal
    {
        public  string Name { get; set; }

        public Animal (string name)
        {
            Name = name;
        }
        public abstract void Print();
    }
    
    class Dog : Animal 
    {
        private float speed;
        public Dog(float speed, string name) : base (name)
        {
            this.speed = speed;
            //Console.WriteLine("Speed: " + speed);

        }
        public override void Print()
        {
            Console.WriteLine("Dog Speed: " + speed);
        }
    }
    class Cat : Animal
    {
        private float speed;
        public Cat(float speed, string name): base(name)
        {
            this.speed = speed;
        }
        public override void Print()
        {
            Console.WriteLine("Cat Speed: " + speed);
        }
    }

    class MainClass 
    {
        public static void Main (string [] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "Alex"));
            animals.Add(new Dog(12.58f, "Tom"));
            animals.Add(new Cat(12.58f, "Bella"));

            //Dog tom = new Dog(12.23f, "Tom");
            //Console.WriteLine(tom.Name);

            foreach (Animal animal in animals)
            {
                //if (animal is Animal)
                //Console.WriteLine(animal.Name);
                //if (animal is Cat)        
                //(animal as Cat).Print();
                animal.Print();
            }

            //Dog jerry = new Dog(25.6f, "Jerry");
           // Console.WriteLine(jerry.Name);
            //Console.WriteLine();
            //jerry.Print();
        }
    }*/

    //Интерфейсы 
    /*/interface ISoda
    {
        int property { get; set; }
        void Print();
    }
    interface ISol
    {
        void Sol();
    }
    class  Test : ISoda, ISol
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Some text: ");
        }
        public void Sol()
        {
            Console.WriteLine("Sol methord");
        }
    }
    class Test2 : ISoda
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("This is text2: ");
        }
    }
    class MainClass
        {
            public static void Main(string[] args)
            {
            Test test = new Test();
            Test2 test2 = new Test2();

            test.property = 12;
            test.Print();
            Console.WriteLine(test.property);
            test.Sol();

            Console.WriteLine();

            test2.property = 22;
            test2.Print();
            Console.WriteLine(test2.property);

            Console.ReadLine();
            }

        }*/
    //Перегрузка методов
    /* class Some
     {
         public void Multipy( int a, int b)
         {
             Console.WriteLine("Result is: " + a * b);
         }

         public void Multipy(int a, int b, int c)
         {
             Console.WriteLine("Result is: " + a * b * c);
         }
         public void Multipy(string str)
         {
             Console.WriteLine("Result is: " + str);
         }
     }
     class MainClass
     {
         public static void Main(string[] args)
         {
             Some test = new Some();
             test.Multipy(2, 22);
             test.Multipy(2, 22, 50);
             test.Multipy("Some test ");
         }
     }*/
    //Перечисления (enum)
    /* enum Breed { dog, cat, bird, bear, tiger};
     class Animal
     {
         public Breed breed;
         public Animal (Breed breed)
         {
             this.breed = breed;
         }
         public void Print()
         {
             Console.WriteLine(breed);
         }
     }
     class MainClass
     {
         public static void Main(string[] args)
         {
             Animal dog = new Animal(Breed.bird);
             dog.Print();
         }
     }*/
    //Структуры

    struct Book
    {
        public string title;
        public string name;
        public string author;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Book b;
        }
    }
}




