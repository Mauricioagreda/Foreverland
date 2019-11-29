using MenuesConsola;
using ProgramaCajero.Menu;
using ProgramaCliente.Menu;
using System;

namespace ProgramaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuInicio = new MenuLogin();
            menuInicio.mostrar();
        }
    }
}

