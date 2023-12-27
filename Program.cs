using Dio_POO_C_.models;

namespace Dio_POO_C_
{
    class Program
    {
        static void Main()
        {
            // Cria uma instância de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia123", "123456789012345", 64);

            // Chama os métodos da classe Nokia
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            // Cria uma instância de Iphone
            Iphone iphone = new Iphone("987654321", "iPhoneX", "987654321098765", 128);

            // Chama os métodos da classe Iphone
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
