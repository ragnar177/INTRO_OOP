
class Operaciones_Aritmeticas
{
    //propiedades (atributos)
    public int number_one { get; set;}
    public int number_two { get; set;}

    //metodos (funciones o acciones)
    public void sumar_numeros(){
        // operaciones
        int resultado = number_one + number_two;
        // auput, puede ser impresa o return
        Console.WriteLine(resultado);
    }
    public void multiplicar_numeros(){
        int resultado = number_one * number_two;

        Console.WriteLine(resultado);
        
    }
    public void restar_numeros(){
        int resultado = number_one - number_two;

        Console.WriteLine(resultado);
        
    }
    public void dividir_numeros(){
        int resultado = number_one / number_two;

        Console.WriteLine(resultado);
        
    }
 }