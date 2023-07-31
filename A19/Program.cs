using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19
{
    public delegate int  ArithmaticOperations(int n1, int n2);
    public delegate T Operation<T>(T a, T b);

    internal class Program
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }
        public static int Mul(int n1, int n2)
        {
            return n1* n2;
        }
        static T PerformOperation<T>(T a, T b, Operation<T> operation)
        {
            return operation(a, b);
        }
        static void Main(string[] args)
        {
            bool exit=true;
            while(exit)
            {
                Console.WriteLine("Select\na.Dlegate\nb.Generic Delegate\nc.Exit");
                char select=char.Parse(Console.ReadLine().ToLower());
                switch(select)
                {
                    case 'a':
                        char ch;
                        Console.WriteLine("Enter number 1");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2");
                        int num2 = int.Parse(Console.ReadLine());
                        do
                        {

                            Console.WriteLine("Select Operation\n1.Addition\n2.Substaction\n3.Multiply\n4.Divide");
                            int op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine("Addition");
                                    ArithmaticOperations addop = new ArithmaticOperations(Add);
                                    Console.WriteLine($"{num1}+{num2} = " + addop(num1, num2));

                                    break;
                                case 2:
                                    Console.WriteLine("Substraction");
                                    ArithmaticOperations subop = new ArithmaticOperations(Sub);
                                    Console.WriteLine($"{num1}-{num2} = " + subop(num1, num2));
                                    break;
                                case 3:
                                    Console.WriteLine("Multiply");
                                    ArithmaticOperations mulop = new ArithmaticOperations(Mul);
                                    Console.WriteLine($"{num1}*{num2} = " + mulop(num1, num2));
                                    break;
                                case 4:
                                    Console.WriteLine("Divide");
                                    ArithmaticOperations divop = new ArithmaticOperations(Div);
                                    Console.WriteLine($"{num1}/{num2} = " + divop(num1, num2));
                                    break;
                                default:
                                    Console.WriteLine("Invaid Operation");
                                    break;
                            }


                            Console.WriteLine("if you want to continue with operation selection press y");
                            ch = char.Parse(Console.ReadLine().ToLower());
                        } while (ch == 'y');


                        break;
                    case 'b':
                        Console.WriteLine("Generic delegate");
                        char ch1;
                        do
                        {
                            Console.WriteLine("Select \n1.integer\n2.double");
                            int dt = int.Parse(Console.ReadLine());
                            switch (dt)
                            {
                                case 1:
                                    Console.WriteLine("Operations on integer values");
                                    Console.WriteLine("Enter number 1");
                                    int n1= int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter number 2");
                                    int n2= int.Parse(Console.ReadLine());
                                    char yes;
                                    do
                                    {
                                        Console.WriteLine("Select Operation\nadd-Addition\nsub-Substaction\nmul-Multiply\ndiv-.Divide");
                                        string op = Console.ReadLine().ToLower();
                                        switch (op)
                                        {
                                            case "add":
                                                Operation<int> addint = (a, b) => a + b;
                                                Console.WriteLine($"{n1}+{n2} = " + PerformOperation(n1, n2, addint));
                                                break;
                                            case "sub":
                                                Operation<int> subint = (a, b) => a - b;
                                                Console.WriteLine($"{n1}-{n2} = " + PerformOperation(n1, n2, subint));
                                                break;
                                            case "div":
                                                Operation<int> divint = (a, b) => a / b;
                                                Console.WriteLine($"{n1}/{n2} = " + PerformOperation(n1, n2, divint));
                                                break;
                                            case "mul":
                                                Operation<int> mulint = (a, b) => a * b;
                                                Console.WriteLine($"{n1}*{n2} = " + PerformOperation(n1, n2, mulint));
                                                break;
                                            default:Console.WriteLine("Invalid selection");
                                                break;

                                        }
                                        Console.WriteLine("If you want to continue with integer operation press y");
                                        yes = char.Parse(Console.ReadLine().ToLower());
                                    } while (yes == 'y');
                                    
                                    
                                   
                                     
                                    break;
                                case 2:
                                    Console.WriteLine("Operations on double values");
                                    Console.WriteLine("Enter number 1");
                                    double a1 = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter number 2");
                                    double a2 = double.Parse(Console.ReadLine());
                                    char quit;
                                    do
                                    {
                                        Console.WriteLine("Select Operation\nadd-Addition\nsub-Substaction\nmul-Multiply\ndiv-.Divide");
                                        string op = Console.ReadLine().ToLower();
                                        switch (op)
                                        {
                                            case "add":
                                                Operation<double> adddouble = (a, b) => a + b;
                                                Console.WriteLine($"{a1}+{a2} = " + PerformOperation(a1, a2, adddouble));
                                                break;
                                            case "sub":
                                                Operation<double> subdouble = (a, b) => a - b;
                                                Console.WriteLine($"{a1}-{a2} = " + PerformOperation(a1, a2, subdouble));
                                                break;
                                            case "div":
                                                Operation<double> divdouble = (a, b) => a / b;
                                                Console.WriteLine($"{a1} / {a2} = " + PerformOperation(a1, a2, divdouble));
                                                break;
                                            case "mul":
                                                Operation<double> muldouble = (a, b) => a * b;
                                                Console.WriteLine($"{a1} * {a2} = " + PerformOperation(a1, a2, muldouble));
                                                break;
                                            default:
                                                Console.WriteLine("Invalid selection");
                                                break;

                                        }
                                        Console.WriteLine("If you want to continue with double operation press y");
                                        quit = char.Parse(Console.ReadLine().ToLower());
                                    } while (quit == 'y');


                                    break;
                                
                                default:
                                    Console.WriteLine("Invalid Selection");
                                    break;
                            }
                            Console.WriteLine("If you want to continue with delegate/ generic delegate selection press y");
                            ch1 = char.Parse(Console.ReadLine().ToLower());
                        } while (ch1 == 'y');

                        break;
                    default:exit=false;
                        Console.WriteLine("Invalid selection");
                        break;
                }

            }
            Console.ReadKey();
         

          
        }
    }
}
