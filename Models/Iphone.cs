using System;

namespace TRILHA_NET_POO_DESAFIO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor herdando da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }
        // Sobrescrevendo método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando '{nomeApp}' no iPhone via App Store...");
        }
    }
}
