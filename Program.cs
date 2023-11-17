
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Podriamos poner los estados de los jugadores en la clase Jugador, todo junto

class Program
{
    const int MAX = 1; // Porque es solo un jugador por ordenador (CREO)

    class Jugador // Atributos de un jugador
    {
        public string nombre;
        public Estado estado = new Estado();
    }

    class Estado // Estado de la partida
    {
        public int cofresacumulados;
        public int monedasactuales;
    }

    static void InicioJuego()
    {
        
        Jugador mijugador = new Jugador();
        Console.Write("Introduce tu nombre de jugador: ");
        mijugador.nombre = Console.ReadLine();
        mijugador.estado.monedasactuales = 0;
        mijugador.estado.cofresacumulados = 0;
        Menu(mijugador);
        TextWriter archivo = new StreamWriter("Jugador.txt");
        TextWriter archivo2 = new StreamWriter("Inventario.txt");


    }
    static void Menu(Jugador mijugador)
    {   
        Console.WriteLine("Monedas: {0}", mijugador.estado.monedasactuales);
        Console.WriteLine("Cofres abiertos: {0}", mijugador.estado.cofresacumulados);
        Console.WriteLine("1--> Tirar \n2--> Inventario\n3-->Finalizar");
    }

    static void AbrirCofre()
    {
        Console.Write("Pulsa la tecla X para abrir un cofre: ");
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        InicioJuego();
    }
}
