using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonelist
{
    class Program
    {
        /* För att få MySqlCommand att fungera:
         *   Tools → Nuget Package Manager → Package Manager Console
         * I consolen skriv:
         *   Install-Package MySqlConnector -Version 1.3.7
         * Källa: https://www.nuget.org/packages/MySqlConnector/
         * Röda vågor under fixas med MySqlCommand:
         *   using MySqlConnector;
         *   using System.Data.SqlClient;
         */

        /* ÄNDRA HÄR NEDANFÖR: */
        static string connString = "Server=localhost;User ID=root;Password=dittlösenord;Database=dindatabas";
        static string table = "dintabell";

        static string GetString(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
        static int GetInt(string prompt) => Int32.Parse(GetString(prompt));
        static DateTime GetDateTime(string prompt) => DateTime.Parse(GetString(prompt));

        /*********************************************************************************/
        /* ÄNDRA HÄR NEDANFÖR: */
        static void ListTable()
        {
            /* NYI: Implementera list.sql här!  */
        }
        static void DeleteID(int ID)
        {
            /* NYI: Implementera remove.sql här! */
        }
        static void InsertNew(int ID, string persname, string surname, string street, string phone, DateTime birthday)
        {
            /* NYI: Implementera insert.sql här! */
        }
        static string[] menu =
        {
            "+-------kommandon------+",
            "| 1. visa kontakter    |",
            "| 2. lägg till kontakt |",
            "| 3. ta bort kontakt   |",
            "| 4. avsluta           |",
            "+----------------------+"
        };
        /*********************************************************************************/
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till telefonlistan!");
            string command;
            do
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i]);
                }
                Console.Write("Ange ett kommando: ");
                command = Console.ReadLine();
                int ID;
                switch (command)
                {
                    case "1":
                        Console.WriteLine("Visa listan av kontakter:");
                        ListTable();
                        break;
                    case "2":
                        Console.WriteLine("Lägg till en ny kontakt:");
                        ID = GetInt("Ange ID");
                        string persname = GetString("Ange förnamn");
                        string surname = GetString("Ange efternamn");
                        string street = GetString("Ange gatuadress");
                        string phone = GetString("Ange telefon");
                        DateTime birthday = GetDateTime("Ange födelsedag");
                        InsertNew(ID, persname, surname, street, phone, birthday);
                        break;
                    case "3":
                        Console.WriteLine("Ta bort en kontakt:");
                        ID = GetInt("Ange ID");
                        DeleteID(ID);
                        break;
                    case "4":
                        Console.WriteLine("Hej då!");
                        break;
                    default:
                        Console.WriteLine("Ogiltig val.");
                        break;
                }
            } while (command != "4");
        }
    }
}
