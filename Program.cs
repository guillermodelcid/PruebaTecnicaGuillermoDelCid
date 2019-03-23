using System;
using GuillermoDelCid.Model;
using System.Collections.Generic;
using GuillermoDelCid.Entidades;
using GuillermoDelCid.Excepciones;

namespace GuillermoDelCid
{
    class Program
    {
        static void main(string[] args)
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.MostrarMenu();
            }
            catch (OpcionMenuException e)
            {
                DateTime fecha = DateTime.Now;

                Console.WriteLine(e.Message);
            }
        }
    }
}
