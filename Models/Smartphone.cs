using System;

namespace TRILHA_NET_POO_DESAFIO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        // Construtor Completo
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

       public void ExibirInfo()
        {
            Console.WriteLine($"Celular: {Modelo} ({Memoria}GB) | Número: {Numero}");
        }

        public void Ligar()
        {
            Console.WriteLine($"[{Modelo} ({Memoria}GB)] Ligando do número {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"[{Modelo} ({Memoria}GB)] Recebendo ligação no número {Numero}...");
        }

        // Método abstrato para instalar aplicativos
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
