using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;

            Console.WriteLine("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }
            int x = 0; int y = 0;
            int vx = 1; int vy = 1;
            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
            Point point;
            point.x = 10;
            point.y = 10;
            point = new Point(3, 5);
            Console.WriteLine(point.x + " / " + point.y);

            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;
            pointClassB.x = 100; pointClassB.y = 200;
            Console.WriteLine(pointClassA.x + "/" + pointClassA.y);
            Console.WriteLine(pointClassB.x + "/" + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;
            pointStructB.x = 100; pointStructB.y = 200;
            Console.WriteLine(pointStructA.x + "/" + pointStructA.y);
            Console.WriteLine(pointStructB.x + "/" + pointStructB.y);

            */




            /*
            using (Dummy dummy = new Dummy())
            {
     
                List<Product> list = new List<Product>()
                {
                new Product(){ Name="고구마", Price=1500},
                new Product(){ Name="사과", Price=2400},
                new Product(){ Name="바나나", Price=1000},
                new Product(){ Name="배", Price=3000},

                };

                list.Sort();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            IBasic basic = new TestClass();
            //basic.someThing();  //호출 불가능
            (basic as TestClass).someThing();

            */

            /*
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();
            */

            /*
            File.WriteAllText(@"C:\\Temp\test.txt", "문자열 메시지");
            Console.WriteLine(File.ReadAllText(@"C:\\Temp\test.txt"));
            */

            /*
            using (StreamWriter writer = new StreamWriter(@"C:\\Temp\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("streamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다.");

                for (int i = 0; i < 10; i++)
                { 
                    writer.WriteLine("반복문 - "+i);
                }
            }

            Console.WriteLine(File.ReadAllText(@"C:\\Temp\test.txt"));

            using (StreamReader reader = new StreamReader(@"C:\\Temp\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
               
            }

            */

            
            //예외
            string[] array = { "가", "나" };

            //throw new FormatException();
            try {
                throw new HungryException("배고파요~");
            } catch (Exception e) {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            
            Boolean isInputLoop = true;

            while (isInputLoop)
            {
                Console.Write("숫자 입력(0 ~ "+(array.Length-1)+") : ");
                string input = Console.ReadLine();

                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine("위치 값 : " + array[index]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("숫자가 아닌것을 입력해 FormatException이 발생했습니다.");
                    Console.WriteLine(e.GetType());
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("0 이상 "+array.Length+" 미만 값을 입력하세요");
                    Console.WriteLine(e.GetType());
                }
                catch (Exception e)
                {
                    Console.WriteLine("예외가 발생했습니다.");
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    Console.WriteLine("프로그램 종료");
                }

            }
           



            try
            {
                int[] array = { 52, 54, 74, 24 };
                Console.Write("숫자 입력(0 ~ " + (array.Length - 1) + ") : ");
                string input = Console.ReadLine();

                int index = int.Parse(input);
                Console.WriteLine(array[index]);
            }
            //var는 예외 매개변수 부분에서 사용할 수 없다.
            catch (FormatException e){
                Console.WriteLine("format exception");
                Console.WriteLine(e.GetType());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
                Console.WriteLine(e.GetType());
            }


        }
        class TestClass : IBasic
        {
            public void someThing() 
            { 
                
            }
            public int TestProperty { 
                get => throw new NotImplementedException(); 
                set => throw new NotImplementedException(); 
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }
        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }
            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                this.testA = test;
                this.testB = test;
            }
        }
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }


}
