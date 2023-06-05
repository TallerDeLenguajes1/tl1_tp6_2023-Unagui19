//Ingresar cadena y ver su longitud
Console.WriteLine("Ingrese un texto, numeros o lo que sea: ");
string? ingresar1=Console.ReadLine();
while (string.IsNullOrEmpty(ingresar1))
{
    Console.WriteLine("\nIngreso una cadena vacía. Vuelva a intentarlo:");
    ingresar1=Console.ReadLine();
}

int longitud;
longitud=ingresar1.Length;
Console.WriteLine("Longitud de la cadena:" + longitud);

//Ingreso de segunda cadena y concatenar con la primera

Console.WriteLine("\nIngrese otro texto, numeros o lo que sea: ");
string? ingresar2=Console.ReadLine();

while (string.IsNullOrEmpty(ingresar2))
{
    Console.WriteLine("\nIngreso una cadena vacía. Vuelva a intentarlo:");
    ingresar2=Console.ReadLine();
}
ingresar2=string.Concat(ingresar1," ",ingresar2);
Console.WriteLine(ingresar2 + "\n");

//Extraer subcadena

int inicio, lon;

Console.WriteLine("\n Para extraer una subcadena de la cadena\""+ ingresar1+"\", ingrese la posicion en esa cadena desde donde desea extraer la subcadena (de 0 en adelante) ");
string? x=Console.ReadLine();

while(!int.TryParse(x,out inicio) && inicio>longitud && inicio<0)
{
    Console.WriteLine("\nIngreso una valor invalido. Vuelva a intentarlo:");
    x=Console.ReadLine();
}
 
Console.WriteLine("\nIngrese la longitud de la subcadena(entre la posicion deseada  el final de la cadena):");
x=Console.ReadLine();
while(!int.TryParse(x,out lon) && lon>(longitud-inicio-1) && lon<=0)
{
    Console.WriteLine("\nIngreso una valor invalido. Vuelva a intentarlo:");
    x=Console.ReadLine();
}

string subcadena=ingresar1.Substring(inicio,lon);
Console.WriteLine("Subcadena generada: " + subcadena);

//Recorrer cadena con foreach

foreach (var item in ingresar1)
{
    Console.WriteLine(item +"\t");
}


//Buscar ocurrencia en palabra
Console.WriteLine("\n Ocurrencia a encontrar:");
string? ingresar=Console.ReadLine(); 
int indice=0, contador=0;

while(string.IsNullOrEmpty(ingresar))
{
    Console.WriteLine("\nIngreso una cadena vacía. Vuelva a intentarlo:");
    ingresar=Console.ReadLine();
}
while (indice != -1)
{
    contador++;
    indice = ingresar1.IndexOf(ingresar, indice + ingresar.Length);
}

Console.WriteLine("El substring '" + ingresar + "' aparece " + contador + " veces en el texto.");
