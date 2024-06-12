using System;
using System.Collections.Generic;

namespace TallerMecanico
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
    }

    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Clientes - Taller Mecánico");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarCliente();
                        break;
                    case "2":
                        ListarClientes();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void RegistrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Write("Nombre: ");
            cliente.Nombre = Console.ReadLine();

            Console.Write("Dirección: ");
            cliente.Direccion = Console.ReadLine();

            Console.Write("Teléfono: ");
            cliente.Telefono = Console.ReadLine();

            Console.Write("Correo Electrónico: ");
            cliente.CorreoElectronico = Console.ReadLine();

            clientes.Add(cliente);

            Console.WriteLine("Cliente registrado con éxito.");
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarClientes()
        {
            Console.WriteLine("Lista de Clientes:");
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine($"Nombre: {cliente.Nombre}");
                    Console.WriteLine($"Dirección: {cliente.Direccion}");
                    Console.WriteLine($"Teléfono: {cliente.Telefono}");
                    Console.WriteLine($"Correo Electrónico: {cliente.CorreoElectronico}");
                }
            }

            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
