
namespace EjercicioHerencia
{
    public class geometria:Operaciones
    {
        private double radio;
        private double altura;

        // Constructor para inicializar los valores
        public geometria(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        // Método para imprimir los resultados de las operaciones
        public void Imprimir()
        {
            Console.WriteLine($"Área del círculo con radio {radio}: {CalcularAreaCirculo(radio)}");
            Console.WriteLine($"Longitud de la circunferencia con radio {radio}: {CalcularLongitudCircunferencia(radio)}");
            Console.WriteLine($"Volumen del cilindro con radio {radio} y altura {altura}: {CalcularVolumenCilindro(radio, altura)}");
        }
    }
}
