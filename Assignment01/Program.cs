using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment01
{
    public class Program
    {
        //program doesn't need to be instanciated
        //it can be used in main
        //Main is a static method

        public static void Main(string[] args)
        {
            Console.WriteLine("* Static vs Non-static method---------------------------------------------------");
            /* 1.Static vs Non-static method*/
            //create a class object
            StaticNonstaticMethod x = new StaticNonstaticMethod();

            //using non-static method 
            Console.WriteLine(x.calcul(12, 12));

            //error!
            //static method can't work with object or without calling class name directly
            //Console.WriteLine(x.calculation123(12, 12));
            //Console.WriteLine(calculation123(12, 12));
            
            //without object, calling static method thru it's class name
            Console.WriteLine(StaticNonstaticMethod.calculation123(12, 12));
            Console.WriteLine();


            Console.WriteLine("* Static vs Non-static class---------------------------------------------------");
            /*1.Static vs Non-static class*/
            //error!
            //Static class can't create an instance
            //StaticNonstaticClass x = new StaticNonstaticClass();
            string fName = StaticNonstaticClass.Firstname;
            string lName = StaticNonstaticClass.Lastname;
            Console.WriteLine($"Hi, {fName} {lName}");
            Console.WriteLine();


            Console.WriteLine("* Data type-----------------------------------------------------");
            /*2. Data type*/
            Console.WriteLine("\nValue type example");
            int i = 100;
            Console.WriteLine(i);

            //even tho the value of 'i' got changed from this method
            DataType.ChangeValue(i);

            //i is still 100.
            //cause the system creates a seperate copy of the variable
            Console.WriteLine(i);

            Console.WriteLine("\nReference type example");
            DataType.ChangeReferenceType();
            Console.WriteLine();


            Console.WriteLine("* Access Modifier-----------------------------------------------------");
            /*3.Access Modifier*/
            //in another project
            Console.WriteLine();


            Console.WriteLine("* String.Format() -----------------------------------------------------");
            /*4. String.Format()*/
            Console.WriteLine();
            StringFormat sf = new StringFormat();

            //format string -> it's a static method that doesn't need any object creations
            string strFormat = String.Format("1. Hello {0}, today is {1}", sf.name, sf.today);
            Console.WriteLine(strFormat);

            //another way
            sf.preferedStringFormat();

            //another way - not prefered
            sf.notPreferedStringFormat();
            Console.WriteLine();


            Console.WriteLine("* Inheritance -----------------------------------------------------");
            /*Inheritance studying*/
            Inheritance chef = new Inheritance();
            chef.MackSpecialDish();

            Inheritance01 italianChef = new Inheritance01();
            //but the normal chef can't make a pasta
            italianChef.MakePasta();
            italianChef.MackSpecialDish();
            Console.WriteLine();


            Console.WriteLine("* Getter and Setter -----------------------------------------------------");
            /*Getter and Setter studying*/
            GetterSetter avenger = new GetterSetter("The Avengers", "John", "Dog");
            GetterSetter hulk = new GetterSetter("The Hulk", "Bruno", "PG");

            //you can't update like this here cause rating is a private
            //to solve this, getter and setter will be helped
            //avenger.rating("dog");

            //getter and setter can't be used like a method
            //avenger.Rating("dog");

            Console.WriteLine();
            Console.WriteLine(avenger.Rating);
            hulk.Rating = "PG-13";
            Console.WriteLine(hulk.Rating);
            hulk.Rating = "Cat";
            Console.WriteLine(hulk.Rating);
            Console.WriteLine();


            Console.WriteLine("* Constructor -----------------------------------------------------");

            /*Constructor Studying*/
            //everytime I create new book,
            //il see the msg thats in the constructor

            /*
             * instead of these ---->
             * Constructor book = new Constructor();
            book.title = "Harry Potter";
            book.author = "JK Rowling";
            book.pages = 400;

            Constructor book1 = new Constructor();
            book1.title = "Lord of the rings";
            book1.author = "Tolkein";
            book1.pages = 700;*/

            //-----> simply like this
            Constructor book = new Constructor("Harry Potter", "JK Rowling", 400);
            Constructor book1 = new Constructor("Lord of the rings", "Tolkein", 700);

            Console.WriteLine($"\n{book.title}, {book.author}, {book.pages}");
            Console.WriteLine($"{book1.title}, {book1.author}, {book1.pages}");
            Console.WriteLine();


            Console.WriteLine("* Generic -----------------------------------------------------");
            /*5. Generic Studying*/
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 3.4, 2.5, 53.1 };
            string[] stringArray = { "hey", "hey1", "hey2" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            Console.WriteLine();

            //dont need to make many types of methods
            displayElementsGeneric(intArray);
            displayElementsGeneric(doubleArray);
            displayElementsGeneric(stringArray);
            Console.WriteLine();


            Console.WriteLine("* Delegate -----------------------------------------------------");
            /*6. Delegate studying*/
            //함수를 담고싶은 변수가 있을 때 사용
            Delegate d = new Delegate();

            Console.WriteLine($"Testing delegate:{d.AddTest(1, 1)}");

            /*Event*/
            /// 객체의 사건을 표현하는 형식
            /// EventHandler(이벤트 처리기): 이벤트 발생 시 실행되는 메소드
            /// 동작 원리는 delegtate와 유사
            /// but 이벤트는 외부에서 직접 호출할 수 없음. 객체의 은닉성을 위해
            /// delegate를 이벤트 한정자로 수식해 선언
        }
        public static void displayElements(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
        public static void displayElements(double[] array)
        {
            foreach (double item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
        public static void displayElements(String[] array)
        {
            foreach (String item in array)
            {
                Console.WriteLine(item + " ");
            }
        }

        public static void displayElementsGeneric<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}



//overloading https://yeko90.tistory.com/entry/c-%EC%83%9D%EC%84%B1%EC%9E%90-%EC%98%A4%EB%B2%84%EB%A1%9C%EB%94%A9-%EA%B0%9C%EB%85%90
//callbyvalue, callbyreference
//delegate https://developer-talk.tistory.com/207
//generic https://developer-talk.tistory.com/206
//format.sting https://fiftiesstudy.tistory.com/218