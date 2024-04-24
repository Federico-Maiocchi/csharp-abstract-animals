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
                animal.Sleep();
                animal.MakeTowards();
                animal.Eat();
            }

            
            
            //* *Esercizio 2 : interfacce * *
            //Alcuni degli animali che abbiamo creato volano, altri nuotano.
            //Gli animali che volano hanno il seguente metodo:
            //-void Vola()(mostra a video “Sto volando!!!”)
            //Gli animali che nuotano hanno il seguente metodo:
            //-void Nuota()(mostra a video “Sto nuotando!!!”)
            //Scrivere un programma avente 2 metodi:
            //-void FaiVolare(IVolante animale)
            //- void FaiNuotare(INuotante animale)
            //Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
            //Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
        }
    }
}
