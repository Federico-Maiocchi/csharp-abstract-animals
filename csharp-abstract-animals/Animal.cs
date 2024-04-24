using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
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

    public class Bird : Animal
    {
        public override void MakeTowards()
        {
            Console.WriteLine("chip striminzito");
        }

        public override void Eat()
        {
            Console.WriteLine("grass");
        }
    }

    public class Eagle : Animal
    {
        public override void MakeTowards()
        {
            Console.WriteLine("fiscio rompitimpani");
        }


        public override void Eat()
        {
            Console.WriteLine("meat");
        }
    }

    public class Dolphin : Animal
    {
        public override void MakeTowards()
        {
            Console.WriteLine("flipper");
        }

        public override void Eat()
        {
            Console.WriteLine("fish");
        }
    }
}
