using System;

namespace Laboratorio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Ejemplo utilizando las variables de instancia de Clase.
            client.FirstName = "Su_Nombre";
            client.FirstName = "Su_Apellido";
            client.Age = 15;
            client.Id =1;

            Console.WriteLine(client.GetFullName());
        }
    }
}


public class Client
{
    // Declarando variable de instancia en clase
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ushort Age { get; set; }

    public string GetFullName()
    {
        // Utilizando variable de instancia dentro de metodos de la clase.
        return FirstName + " " + LastName;
    }
}