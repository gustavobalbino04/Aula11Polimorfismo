using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dadosplayer player = new Dadosplayer();
            //sem argumentos
            System.Console.WriteLine( player.Calcular() );
            //com 1 argumento em string
            System.Console.WriteLine( player.Calcular("homen de ferro") );
            //com 2 argumentos em string
            System.Console.WriteLine( player.Calcular("Gustavo","Balbino") );
            //com 1 argumento em string e outro em int
            System.Console.WriteLine( player.Calcular("intermediario",12) );
            //com um argumento em int
            System.Console.WriteLine( player.Calcular(100) );
            //com 2 argumentos em int
            System.Console.WriteLine( player.Calcular(100,50) );
        }
    }
}