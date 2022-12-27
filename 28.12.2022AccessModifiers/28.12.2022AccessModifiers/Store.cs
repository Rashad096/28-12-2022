using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2022AccessModifiers
{
    internal class Store
    {
        public Notebook[] notebooks;
        public string Name;



        public void AddNotebook(ref Notebook[] arr, Notebook value)

        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;

        }

        public Notebook[] SearchByName(ref Notebook[] arr, string note)
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

        public void ShowNoteBoks(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Name: " + arr[i].Name);
                Console.WriteLine("Name: " + arr[i].Price);
                Console.WriteLine("Name: " + arr[i].RAM);
            }
        }
    }
}
        

        

       

    
