// Resolver problema de Calculadora.

//Calcular la suma de dos numeros.
//Pedir y leer dos numeros ingresados por el usuario.
//Moostrar el resultado en pantalla */



//Console.WriteLine("Ingrese el primer numero");
//Numero1 = int.Parse(Console.ReadLine());



//Console.WriteLine("Ingrese el segundo numero");
//Numero2 = int.Parse(Console.ReadLine());

//Resultado = Numero1 + Numero2;
//Console.WriteLine(Resultado);

//if(Desicion == "+")
//{ Resultado = Numero1  + Numero2;
//}
//else
//{ Resultado = Numero1 + Numero2;}
//Console.WriteLine($"el resultado  {Numero1 + Numero2} + $ da como resultado [Resultado]");
//Console.WriteLine($" { Numero1 }{ Desicion}{ Numero2 = }{ Resultado}");



// switch (switch - case
int Numero1;
int Numero2;
int Resultado;
Console.WriteLine("quiere sumar o restar? ( + o -)");
Operacion = Console.ReadLine();
string Operacion;

switch (Operacion)
{ case "+":
        Resultado = Numero1 + Numero2;

        break;

            case "-":
        Resultado = Numero1 - Numero2;

        break;
            case "*":
        Resultado = Numero1 * Numero2;

        
            break;
    case "/":
        Resultado = Numero1 / Numero2;
        break;

    default:
        Console.WriteLine("la operacion no es valida");
        break;
           
}

//operadores logicos 
//&& ampersand = "y"
// (PLECA) || "O"

if(Operacion == "+" || Operacio "-" || Operacion==  "*" || Operacion== "/")
{
    Console.WriteLine($" {Numero1}{Operacion} {Numero2}  = {Resultado}");
}




//    Console.WriteLine("falso")



// ---------------------------
//pedir dos numeros y mostrar el mayor
//int nro1;
//    int nro2;
//    Console.WriteLine("ingrese el primer numero:");
//    nro1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("ingrese el segundo numero:");
//    nro2 = int.Parse(Console.ReadLine());
//    if (nro1 >= nro2)

//    {
//        Console.WriteLine($"el numero mayor es {nro1}");
//    }
//else
//{

//    Console.WriteLine($"el numero mayor es {nro2}");

//}

//if (nro2 >= nro1)
//{
//    Console.WriteLine($"el numero es mayor {nro1}");
//}

//else
//{
//    Console.WriteLine($"elnumero mayor es {nro2}");
//}



