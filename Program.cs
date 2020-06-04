using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: HoraSistema] Exiba a data e a hora atual do sistema.
            Ex.:
            Neste momento são exatamente 13/05/2020 14:58:13.
            */
            
            DateTime HorarioAtual = DateTime.Now;
        
            Console.WriteLine($"Horário atual correspondente a sua localização: {HorarioAtual}");
        }
    }
}
