using System;
using System.Xml.Linq;

namespace _28._12._2022AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[0];

            string select;

            do
            {
                Console.WriteLine("1. Notebooklar uzerinde axtaris et");
                Console.WriteLine("2. Yeni notebook yarat");
                Console.WriteLine("0. Menudan cix");

                select = Console.ReadLine();
                if (select == "1")
                {

                    Console.WriteLine("Axtarish deyerini daxil et:");
                    string  search = Console.ReadLine();
                    var filteredNotes = SearchByName(ref notebooks, search);

                    ShowNoteBoks(filteredNotes);
 
                }
                else if (select=="2")
                {
                    bool check = false;
                    do
                    {
                         check = false;
                        Console.WriteLine("NoteBookun adini daxil et");
                        DateTime notecreation = new DateTime();
                        


                        try
                        {
                            var notebook = CreateNotebook();
                            AddNotebook(ref notebooks, notebook);
                            Console.WriteLine(DateTime.Now);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Xeta Bash verdi");
                        }

                    } while (check);

                   
                
                ShowNoteBoks(notebooks);

                }


            } while (select!="0");
        }





        static Notebook[] SearchByName(ref Notebook[] arr, string note)
        {
            Notebook[] searchedNotes = new Notebook[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.ToLower().Contains(note.ToLower()))
                {
                    Array.Resize(ref searchedNotes, searchedNotes.Length + 1);
                    searchedNotes[searchedNotes.Length - 1] = arr[i];
                }

            }
           return searchedNotes;



        }

        static void ShowNoteBoks(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Name: " + arr[i].Name);
                Console.WriteLine("Name: " + arr[i].Price);
                Console.WriteLine("Name: " + arr[i].RAM);
            }
        }

        static void AddNotebook(ref Notebook[] arr, Notebook value)

        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;

        }

        static Notebook CreateNotebook()
        {
            Console.WriteLine("Notebook'un adi:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {

                throw new NoteBookFormatException("Ad Null yada Space ola bilmez");

            }

            Console.WriteLine("Notebook'un Price:");
            var input = Console.ReadLine();
            double price = Convert.ToDouble(input);
            if (price <= 0)
            {
                throw new NoteBookFormatException("Price deyeri menfi yada sifira beraber ola bilmez");
            }

            Console.WriteLine("NoteBook'un RAM'i:");
            var inputb = Console.ReadLine();
            byte ram = Convert.ToByte(inputb);

            if (ram <= 0)
            {
                throw new NoteBookFormatException("RAM deyeri menfi yada sifira beraber ola bilmez");
            }

            Notebook notebook = new Notebook(name, price, ram);



            return notebook;
        }
    }
}