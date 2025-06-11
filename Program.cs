using GestionareAngajati;
using LibrarySystem;

namespace Lectia_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region EX.1
            //List<Employee> angajati = new List<Employee>();


            //angajati.Add(new FullTimeEmployee("Ion Popescu", 101, 5000, 10000));
            //angajati.Add(new FullTimeEmployee("Maria Ionescu", 102, 6200, 8000));
            //angajati.Add(new PartTimeEmployee("Ana Mihai", 201, 50));
            //angajati.Add(new PartTimeEmployee("Vlad Georgescu", 202, 60));

            //foreach (var angajat in angajati)
            //{
            //    angajat.AfisareDetalii();
            //    Console.WriteLine();
            //}
            #endregion

            #region EX.2
            Library biblioteca = new Library();


            biblioteca.AddItem(new Book("Morometii", "Marin Preda", 1955));
            biblioteca.AddItem(new Magazine("Science Today", "Redactia", 2023));
            biblioteca.AddItem(new DVD("Interstellar", "Christopher Nolan", 2014));

            biblioteca.ShowAllItems();


            biblioteca.BorrowItem("Morometii");
            biblioteca.BorrowItem("Morometii"); 

            biblioteca.ReturnItem("Morometii");
            biblioteca.ReturnItem("Morometii"); 

            biblioteca.BorrowItem("Science Today");
            biblioteca.BorrowItem("Interstellar");

            biblioteca.ShowAllItems();
            #endregion

        }
    }
}
