bool anda=false;
int num=0, i=0;
double aux=0;
string? numString="";

Console.WriteLine("Ingrese un numero entero");
// Console.ReadLine();
numString= Console.ReadLine();
anda = int.TryParse(numString, out num);

while (!anda)
{
    Console.WriteLine(numString+" no es un número valido");
    Console.WriteLine("Ingrese un valor válido");
    numString= Console.ReadLine();
    anda = int.TryParse(numString, out num);
}

i=numString.Length-1;
do
{
    
    aux+=(num % 10) * Math.Pow(10,i);
    // Console.WriteLine("aux= "+aux);
    num=num/10;
    // Console.WriteLine("num="+num);
    i--;
}
while(num!=0);

Console.WriteLine("Numero Invertido: "+aux);
