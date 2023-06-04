
Console.WriteLine("\t-----Bienvenido a CalculadoraV1.2-----\t\n");
Console.WriteLine("Elija la operación deseada: ");
Console.WriteLine("1-Suma");
Console.WriteLine("2-Resta");
Console.WriteLine("3-Multiplicación");
Console.WriteLine("4-División");
Console.WriteLine("5-Valor Absoluto");
Console.WriteLine("6-Cuadrado");
Console.WriteLine("7-Raiz Cuadrada");
Console.WriteLine("8-Seno");
Console.WriteLine("9-Coseno");
Console.WriteLine("10-Parte entera de un número(de tipo float)\n");


string? ingreso = "";
bool valido;
int opcion = 0; ;
ingreso = Console.ReadLine();
valido = int.TryParse(ingreso, out opcion);

while (!valido && opcion<1 || opcion>10)
{
    Console.WriteLine("Valor incorrecto, ingrese un valor nuevamente: ");
    ingreso = Console.ReadLine();
    valido = int.TryParse(ingreso, out opcion);
}

double num1 = 0, num2 = 0, resultado;
if (opcion<=4)
{
    Console.WriteLine("\nIngrese 2 numeros para operar: ");
    Console.WriteLine("Numero 1: ");
    ingreso = Console.ReadLine();
    valido = double.TryParse(ingreso, out num1);
    if (valido)
    {
        Console.WriteLine("\nNumero 2: ");
        ingreso = Console.ReadLine();
        valido = double.TryParse(ingreso, out num2);
    }
    if (valido)
    {
        if (opcion == 1)
        {
            Console.WriteLine("\t SUMA:");
            resultado = Suma(num1, num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
        }
        else if (opcion == 2)
        {
            Console.WriteLine("\t RESTA:");
            resultado = Resta(num1, num2);
            Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
        }
        else if (opcion == 3)
        {
            Console.WriteLine("\t MULTIPLICACION:");
            resultado = Multipicacion(num1, num2);
            Console.WriteLine(num1 + " * " + num2 + " = " + resultado);
        }
        else
        {
            Console.WriteLine("\t DIVISION:");
            resultado = Division(num1, num2);
            Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
        }
    }
}
else
{
    Console.WriteLine("\nIngrese un número: ");
    ingreso = Console.ReadLine();
    valido = double.TryParse(ingreso, out num1);
    if (valido)
    {
        if (opcion == 5)
        {
            Console.WriteLine("\t VALOR ABSOLUTO:");
            resultado = (int) ValorAbsoluto(num1);
            Console.WriteLine("|"+ 1 + "| " + " = " + resultado);
        }
        else if (opcion == 6)
        {
            Console.WriteLine("\t CUADRADO DE UN NUMERO:");
            resultado = (int)Cuadrado(num1);
            Console.WriteLine(1 + "^2 "  + " = " + resultado);
        }
        else if (opcion == 7)
        {
            Console.WriteLine("\t RAIZ CUADRADA DE UN NUMERO:");
            resultado = RaizCuadrada(num1);
            Console.WriteLine("(" + 1 + ")^(1/2) "  + " = " + resultado);
        }
        else if (opcion == 8)
        {
            Console.WriteLine("\t SENO:");
            resultado = Seno(num1);
            Console.WriteLine("Sen(" + 1 + ") "  + "= " + resultado);
        }
        else if (opcion == 9)
        {
            Console.WriteLine("\t COSENO:");
            resultado = Coseno(num1);
            Console.WriteLine("Cos(" + 1 + ") "  + "= " + resultado);
        }
        else
        {
            Console.WriteLine("\t PARTE ENTERA DE UN NUMERO:");
            resultado = ParteEntera(num1);
            Console.WriteLine("Parte entera de " + 1 + " = " + resultado);
        }
    }
}

Console.WriteLine("\n\t MAYOR O MENOR:");
Console.WriteLine("\nIngrese 2 nuevos numeros por favor: ");
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


double Suma(double num1, double num2)
{
    return num1 + num2;
}

double Resta(double num1, double num2)
{

    return num1 - num2;
}

double Multipicacion(double num1, double num2)
{

    return num1 * num2;
}

double Division(double num1, double num2)
{

    return num1 / num2;
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



