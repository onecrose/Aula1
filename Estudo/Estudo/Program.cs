using System;
/*
Refazendo código pra aprender
Em inglês btw
 */
class MainClass {
    public static void Main (string[] args) {
        double n1, n2, result = 0;
        char op;
        string errormsg = "";

        Console.WriteLine ("Input the 1st value:");
        if (!double.TryParse(Console.ReadLine(), out n1)) {
            Console.WriteLine("Invalid input fot 1st value!");
            return;
        }

        Console.WriteLine ("Input the 2nd value:");
        if (!double.TryParse(Console.ReadLine(), out n2)) {
            Console.WriteLine("Invalid input for the 2nd value!");
            return;
        }

        Console.WriteLine ("Input \n+ for Addition\n- for Subtraction\n* for Multiplication\n/ for Division");
        if (!char.TryParse(Console.ReadLine(),out op)) {
            Console.WriteLine("Invalid operator!");
            return;
        }

        switch (op) {
            case '+':
                Console.WriteLine("Adittion");
                result = n1 + n2;
                break;
            case '-' :
                Console.WriteLine("Subtraction");
                result = n1 - n2;
                break;
            case '*' :
                Console.WriteLine("Multiplication");
                result = n1 * n2;
                break;
            case '/' :
                Console.WriteLine("Division");
                if (n2 != 0) {
                    result = n1 / n2;
                } else {
                    errormsg = "You'll not divide by zero dumbass!";
                }
                break;
            default:
                errormsg = "Invalid Operation!";
                break;
        }

        if (errormsg == "") {
            Console.WriteLine("{0} {1} {2} = {3}", n1, n2, op, result);
        } else {
            Console.WriteLine("ERRO! \n\n{0}", errormsg);
        }
    }
}