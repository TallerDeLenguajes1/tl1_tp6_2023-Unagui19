Console.WriteLine("Ingrese un texto, numeros o lo que sea: ");
string? ingresar=Console.ReadLine();

int longitud;
longitud=ingresar.Length;
Console.WriteLine("Longitud de la cadena:" + longitud);

Console.WriteLine("\nIngrese otro texto, numeros o lo que sea: ");
string? ingresar2=Console.ReadLine();
Console.WriteLine(string.Concat(ingresar," ",ingresar2) + "\n");



