// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

bool anda=false;
int floatNum1=0;
string numString="";
while (!anda)
{
    Console.WriteLine("Ingrese un valor válido");
    numString= Console.Readline();
    anda = float.tryparse(numString, out floatNum1);

    if (!anda)
    {
        Console.WriteLine(numString+" no es un número valido");
    }
    else
    {
        numString.
    }
    

}

Console.WriteLine("Ingrese un numero entero");

Console.Readline();