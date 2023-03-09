using System;
using System.Collections.Generic;

namespace Einkaufsliste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> einkaufsliste = new List<string>();

            Console.WriteLine("Willkommen bei Ihrer Einkaufsliste!");

            while (true)
            {
                Console.WriteLine("\nWas möchten Sie tun? Geben Sie \"add\" ein, um ein Element hinzuzufügen, \"remove\" zum Entfernen eines Elements, \"show\" zum Anzeigen der Liste oder \"exit\" zum Beenden:");

                string eingabe = Console.ReadLine().ToLower();

                if (eingabe == "exit")
                {
                    break;
                }
                else if (eingabe == "add")
                {
                    Console.Write("Geben Sie das Element ein, das Sie hinzufügen möchten: ");
                    string element = Console.ReadLine();
                    einkaufsliste.Add(element);
                    Console.WriteLine("\"" + element + "\" wurde zur Liste hinzugefügt.");
                }
                else if (eingabe == "remove")
                {
                    Console.Write("Geben Sie das Element ein, das Sie entfernen möchten: ");
                    string element = Console.ReadLine();

                    if (einkaufsliste.Remove(element))
                    {
                        Console.WriteLine("\"" + element + "\" wurde aus der Liste entfernt.");
                    }
                    else
                    {
                        Console.WriteLine("\"" + element + "\" ist nicht in der Liste enthalten.");
                    }
                }
                else if (eingabe == "show")
                {
                    Console.WriteLine("\nEinkaufsliste:");
                    foreach (string element in einkaufsliste)
                    {
                        Console.WriteLine("- " + element);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie \"add\", \"remove\", \"show\" oder \"exit\" ein.");
                }
            }

            Console.WriteLine("Danke, dass Sie Ihre Einkaufsliste erstellt haben. Auf Wiedersehen!");
        }
    }
}
