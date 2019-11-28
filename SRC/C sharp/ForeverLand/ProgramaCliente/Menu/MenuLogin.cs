﻿using ForeverLand;
using MenuesConsola;
using System;
using static System.ReadLine; 
using NETCore.Encrypt;
using ForeverLand.ADO;
using ProgramaCliente.Menu;
using ProgramaCliente;

namespace ProgramaCajero.Menu
{
    public class MenuLogin : MenuComponente
    {
        private Cliente Cliente { get; set; }
        private MenuCompuesto PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var mail = prompt("Ingrese mail"));
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                Cliente  = ClienteADO.ADO.clientePorMailPass(mail, pass);
                if (Cliente is null)
                {
                    Console.WriteLine("DNI o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {
                    instanciarMenuesPara(Cliente);
                    PrincipalUsuario.mostrar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {e.Message}");
                Console.ReadKey();
            }

            private void instanciarMenuesPara(Cliente cliente)
            {
                var menuIngresarTarjeta = new MenuIngresarTarjeta(cliente);

                PrincipalUsuario = new MenuCompuesto(menuIngresarTarjeta) { Nombre = "Menu Tarjeta" };
            }
        }

        
    }
}