using System.Security.Cryptography.X509Certificates;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**Esercizio 1 : classi astratte**
            //Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono ?

            //Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
            List <Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Bird());
            animals.Add(new Eagle());
            animals.Add(new Dolphin());

            foreach (var animal in animals) 
            {
                Console.WriteLine($"{animal.GetType().Name}");
                animal.Sleep();
                animal.MakeTowards();
                animal.Eat();
                Console.WriteLine();
            }



            //* *Esercizio 2 : interfacce * *
            //Scrivere un programma che istanzi animali che volano o nuotano e richiamare
            //i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
            

            List<IFlying> animaliVOlanti = new List<IFlying>();
            animaliVOlanti.Add(new Bird());
            animaliVOlanti.Add(new Eagle());

            foreach (var volante in animaliVOlanti)
            {
                Console.WriteLine($"{volante.GetType().Name}");
                volante.Fly();
                Console.WriteLine();
            }
                

            Dolphin dolphin = new Dolphin();

            Console.WriteLine($"{dolphin.GetType().Name}");
            dolphin.Swim();

            

        }
    }
}
