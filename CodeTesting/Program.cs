// See https://aka.ms/new-console-template for more information
/*
 * Data type:
 * bool
 * byte
 * sbyte -128 to 127
 * char
 * string
 * decimal 28-29 digits
 * double ~15-17 digits
 * float ~6-9 digits
 * int 4 byte
 * uint 4 byte
 * long 8 byte
 * ulong 8 byte 
 * short -> -32768 to 32767
 * ushort -> 0 to 65535
 * 
 */
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        consoleSetup();
        Console.WriteLine(String.Format("{0} {1} {2}", ReverseString(), ReverseString(), ReverseString()));
    }

    public static int addNumber()
    {
        Console.WriteLine("Enter first number");
        string? num1Input = Console.ReadLine();
        Console.WriteLine("Enter second number");
        string? num2Input = Console.ReadLine();
        int num1 = 0; int num2 = 0;
        bool isNumber = int.TryParse(num1Input, out num1);
        if (isNumber)
        {
            Console.WriteLine($"First input is number {num1Input}");
        }
        else Console.WriteLine("Inpurt error");
        isNumber = int.TryParse(num2Input, out num2);
        if (isNumber)
        {
            Console.WriteLine($"Second input is number {num2Input}");
        }
        else Console.WriteLine("Input error");
        return num1 + num2;
    }

    public static int addUserNumber()
    {
        Console.WriteLine("Enter first number");
        string? num1Input = Console.ReadLine();
        Console.WriteLine("Enter second number");
        string? num2Input = Console.ReadLine();
        if (num1Input == null || num2Input == null) return 0;
        int num1 = 0;
        int num2 = 0;
        int result;
        try
        {
            num1 = int.Parse(num1Input);
            num2 = int.Parse(num2Input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Format error, input should be number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow number for this data type");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally { Console.WriteLine("Do this finally"); }
        result = num1 + num2;
        Console.WriteLine(result);
        return result;
    }
    public static void consoleSetup()
    {
        //Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();
    }
    private static string ReverseString()
    {
        Console.WriteLine("Please input string");
        string? str = Console.ReadLine();
        char[] messageArray;
        if (str is not null)
        {
            messageArray = str.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
        return " ";
    }
}
