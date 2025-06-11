using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public interface IBorrowable
    {
        void Borrow();
        void Return();
        bool IsBorrowed { get; }
    }

    public abstract class LibraryItem : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; private set; }

        public LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            PublicationYear = year;
            IsBorrowed = false;
        }

        public virtual void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"'{Title}' este deja împrumutat.");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"'{Title}' a fost împrumutat.");
            }
        }

        public virtual void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"'{Title}' nu este împrumutat.");
            }
            else
            {
                IsBorrowed = false;
                Console.WriteLine($"'{Title}' a fost returnat.");
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{GetType().Name} - Titlu: {Title}, Autor: {Author}, An: {PublicationYear}, Împrumutat: {IsBorrowed}");
        }
    }


    public class Book : LibraryItem
    {
        public Book(string title, string author, int year)
            : base(title, author, year) { }
    }


    public class Magazine : LibraryItem
    {
        public Magazine(string title, string author, int year)
            : base(title, author, year) { }
    }


    public class DVD : LibraryItem
    {
        public DVD(string title, string author, int year)
            : base(title, author, year) { }
    }


    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
            Console.WriteLine($"Adăugat: {item.Title}");
        }

        public void BorrowItem(string title)
        {
            var item = items.Find(i => i.Title == title);
            if (item != null)
                item.Borrow();
            else
                Console.WriteLine($"Itemul '{title}' nu a fost găsit.");
        }

        public void ReturnItem(string title)
        {
            var item = items.Find(i => i.Title == title);
            if (item != null)
                item.Return();
            else
                Console.WriteLine($"Itemul '{title}' nu a fost găsit.");
        }

        public void ShowAllItems()
        {
            Console.WriteLine("\n-- Catalog bibliotecă --");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}