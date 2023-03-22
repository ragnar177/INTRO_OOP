Console.WriteLine("numero uno");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("numero dos");
int num_2 = int.Parse(Console.ReadLine());

var operacion_one = new Operaciones_Aritmeticas(){
    number_one = num_1,
    number_two = num_2
};
var operacion_two = new Operaciones_Aritmeticas(){
    number_one = num_1,
    number_two = num_2
};

operacion_one.sumar_numeros();
operacion_one.multiplicar_numeros();
operacion_one.dividir_numeros();
operacion_one.restar_numeros();

while (num_1 == 0);