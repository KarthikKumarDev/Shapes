using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice,id=0;
            do {
                Console.WriteLine("\n\nChoose a Shape: \n1.Circle \n2.Rectangle \n0.Exit");
                choice = int.Parse(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("____CIRCLE____");
                        Console.WriteLine("\n\nEnter the Radius:");
                        int radius=int.Parse(Console.ReadLine()); ;
                        CCircle c1 = new CCircle(id++, radius);
                        float a = c1.findArea();
                        c1.setTotalArea(a);
                        Console.WriteLine("Circle area:" + a);
                        Console.WriteLine("Total Shape Count:" + c1.getCount());
                        Console.WriteLine("Total Area:" + c1.getTotalArea());
                        break;
                    case 2:
                        Console.WriteLine("____RECTANGLE____");
                        Console.WriteLine("\n\nEnter the Length and Breadth:");
                        int len = int.Parse(Console.ReadLine());
                        int width = int.Parse(Console.ReadLine());
                        CRectangle r1 = new CRectangle(id++, len, width);
                        float b = r1.findArea();
                        r1.setTotalArea(b);
                        Console.WriteLine("Rectangle area:" + b);
                        Console.WriteLine("Total Shape Count:"+r1.getCount());
                        Console.WriteLine("Total Area:" + r1.getTotalArea());
                        break;
                    case 0: break;
                }
            } while (choice!=0);
            //For the purpose of implementing Operator Overloading concepts
            CRectangle r2 = new CRectangle(6, 50, 10);
            CRectangle r3 = new CRectangle(6, 100, 10);
            float area = r2 + r3;
            Console.WriteLine("Overloading example area of two statically given rectangles:"+area);
            Console.ReadLine();
        }
    }
}
