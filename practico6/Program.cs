Console.WriteLine("\t-----Bienvenido a CalculadoraV1-----\t\n");
Console.WriteLine("Elija la operación deseada: ");
Console.WriteLine("1-Suma");
Console.WriteLine("2-Resta");
Console.WriteLine("3-Multiplicación");
Console.WriteLine("4-División\n");

String? ingreso = "";
bool valido;
int opcion=0;;
ingreso=Console.ReadLine();
valido= int.TryParse(ingreso, out opcion);

while(!valido)
{
    Console.WriteLine("Valor incorrecto, ingrese un valor nuevamente: ");
    valido= int.TryParse(ingreso, out opcion);
}


int num1=0,num2=0,resultado;

Console.WriteLine("\nIngrese 2 numeros para operar: ");
Console.WriteLine("Numero 1: ");
ingreso=Console.ReadLine();
valido= int.TryParse(ingreso, out num1);
if(valido)
{
    Console.WriteLine("\nNumero 2: ");
    ingreso=Console.ReadLine();    
    valido= int.TryParse(ingreso, out num2);

    if(valido)
    {
        if (opcion==1)
        {
            resultado=Suma(num1, num2);
            Console.WriteLine(num1 + " + "+ num2 + " = "+resultado);
        }
        else if (opcion==2)
        {
        resultado=Resta(num1, num2);
            Console.WriteLine(num1 + " - "+ num2 + " = "+resultado);
        }
        else if (opcion==3)
        {
            resultado=Multipicacion(num1, num2);
            Console.WriteLine(num1 + " * "+ num2 + " = "+resultado);
        }
        else
        {
            resultado=Division(num1, num2);
            Console.WriteLine(num1 + " / "+ num2 + " = "+resultado);
        }
    }
}



int Suma(int num1, int num2)
{
    return num1+num2;    
}

int Resta(int num1, int num2)
{
    
    return num1-num2;
}

int Multipicacion(int num1, int num2)
{
    
    return num1*num2;
}

int Division(int num1, int num2)
{
    
    return num1 / num2;
}