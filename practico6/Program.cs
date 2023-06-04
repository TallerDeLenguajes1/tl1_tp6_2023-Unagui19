Console.WriteLine("\t-----Bienvenido a CalculadoraV1-----\t\n");
Console.WriteLine("Elija la operación deseada: ");
Console.WriteLine("1-Valor Absoluto");
Console.WriteLine("2-Cuadrado");
Console.WriteLine("3-Raiz Cuadrada");
Console.WriteLine("4-Seno");
Console.WriteLine("5-Coseno");
Console.WriteLine("6-Parte entera (de tipo float)");

string? ingreso = "";
bool valido;
int opcion = 0; ;
ingreso = Console.ReadLine();
valido = int.TryParse(ingreso, out opcion);

while (!valido && opcion<1 || opcion>6)
{
    Console.WriteLine("Valor incorrecto, ingrese un valor nuevamente: ");
    ingreso = Console.ReadLine();
    valido = int.TryParse(ingreso, out opcion);
}

int resultado;
double num,res;
Console.WriteLine("\nIngrese un numero: ");
ingreso = Console.ReadLine();
valido = double.TryParse(ingreso, out num);
if (valido)
{
    if (opcion == 1)
    {
        resultado = (int) ValorAbsoluto(num);
        Console.WriteLine("|"+ num + "| " + " = " + resultado);
    }
    else if (opcion == 2)
    {
        resultado = (int)Cuadrado(num);
        Console.WriteLine(num + "^2 "  + " = " + resultado);
    }
    else if (opcion == 3)
    {
        res = RaizCuadrada(num);
        Console.WriteLine("(" + num + ")^(1/2) "  + " = " + res);
    }
    else if (opcion == 4)
    {
        res = Seno(num);
        Console.WriteLine("Sen(" + num + ") "  + "= " + res);
    }
    else if (opcion == 5)
    {
        res = Coseno(num);
        Console.WriteLine("Cos(" + num + ") "  + "= " + res);
    }
    else
    {
        resultado = ParteEntera(num);
        Console.WriteLine("Parte entera de " + num + " = " + resultado);
    }
}


Console.WriteLine("\nIngrese 2 nuevos numeros por favor: ");
double num1 = 0, num2 = 0;
Console.WriteLine("Numero 1: ");
ingreso = Console.ReadLine();
valido = double.TryParse(ingreso, out num1);
if (valido)
{
    Console.WriteLine("\nNumero 2: ");
    ingreso = Console.ReadLine();
    valido = double.TryParse(ingreso, out num2);
    Console.WriteLine("\n");

    if (valido)
    {   
        if(num1==num2)
        {
            Console.WriteLine(num1 + " y " + num2 + " son iguales.");
        }
        else if(Maximo(num1,num2))
        {
            Console.WriteLine("El numero más grande es: " + num1 + " y el más chico es: " + num2 + ".");
        }
        else
        {
            Console.WriteLine("El numero más grande es: " + num2 + " y el más chico es: " + num1 + ".");
        }    
    }
}



int ValorAbsoluto(double num)
{
    return (int)Math.Abs(num);
}

int Cuadrado(double num)
{

    return (int) Math.Pow(num, 2) ;
}

double RaizCuadrada(double num)
{

    return (int)Math.Sqrt(num);
}

double Seno(double num)
{

    return Math.Sin(num);
}

double Coseno(double num)
{

    return Math.Cos(num);
}

int ParteEntera(double num)
{

    return (int)num;
}

bool Maximo(double num1, double num2)
{
    return num1>num2;
}



