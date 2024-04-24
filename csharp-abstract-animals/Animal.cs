using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    //* *Esercizio 2 : interfacce * *

    //Alcuni degli animali che abbiamo creato volano, altri nuotano.
    //Scrivere un programma avente 2 metodi:
    //Gli animali che volano hanno il seguente metodo:
    public interface IFlying
    {
        //-void FaiVolare(IVolante animale)
        public void Fly();
        
    }

    //Gli animali che nuotano hanno il seguente metodo:
    public interface ISwimming
    {
        //- void FaiNuotare(INuotante animale)
        public void Swim();

    }
    //Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().




    //**Esercizio 1 : classi astratte**

    //Dobbiamo realizzare un programma che rappresenti il regno animale.
    //Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
    public abstract class Animal
    {
        //Vogliamo che gli animali abbiano i seguenti metodi
        //- void Dormi()(mostra a video “Zzz”)
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }

        //- void Verso()(mostra a video il verso fatto dall'animale specifico)
        public abstract void MakeTowards();

        //- void Mangia()(mostra a video quello che mangia: erba, carne, ...?)
        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void MakeTowards()
        {
            Console.WriteLine("Bau");
        }

        public override void Eat()
        {
            Console.WriteLine("meat");
        }
    }

    public class Bird : Animal, IFlying
    {
        public override void MakeTowards()
        {
            Console.WriteLine("chip striminzito");
        }

        public override void Eat()
        {
            Console.WriteLine("grass");
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    public class Eagle : Animal, IFlying
    {
        public override void MakeTowards()
        {
            Console.WriteLine("fiscio rompitimpani");
        }


        public override void Eat()
        {
            Console.WriteLine("meat");
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    public class Dolphin : Animal, ISwimming
    {
        public override void MakeTowards()
        {
            Console.WriteLine("flipper");
        }

        public override void Eat()
        {
            Console.WriteLine("fish");
        }

        public void Swim()
        {
            Console.WriteLine("Sto nuotando!!!");
        } 
    }
}
