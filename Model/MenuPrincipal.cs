using System;
using static System.Console;
using System.Collections.Generic;
using GuillermoDelCid.Entidades;
using GuillermoDelCid.Excepciones;

namespace GuillermoDelCid.Model
{
    public class MenuPrincipal
    {
        public List<Vehiculo> ListaDeVehiculos { get; set; }

        public MenuPrincipal()
        {
            this.ListaDeVehiculos = new List<Vehiculo>();
        }
        public void MostrarMenu()
        {
            int opcion = 100;

            do
            {
                try
                {

                    Clear();
                    WriteLine("1. Crear objeto Avión.");
                    WriteLine("2. Crear objeto Submarino");
                    WriteLine("3. Mostrar información de los aviones(Modelo y Marca, Altura máxima y Altura mínima)");
                    WriteLine("4. Mostrar información de los submarinos(Modelo, Marca y profundidad máxima)");
                    WriteLine("5. Salir.");
                    WriteLine("0. Ingrese opción deseada: ");

                    string valor = ReadLine();
                    if (EsNumero(valor) == true)
                    {
                        opcion = Convert.ToInt16(valor);
                    }

                    if (opcion == 1)
                    {
                        CrearObjetoVehiculo(opcion);
                    }
                    else if (opcion == 2)
                    {
                        CrearObjetoVehiculo(opcion);
                    }



                }
                catch (OpcionMenuException e)
                {
                    WriteLine(e.Message);
                }
            } while (opcion != 0);
        }

        public Boolean EsNumero(string valor)
        {
            Boolean resultado = false;

            try
            {
                int numero = Convert.ToInt16(valor);
                resultado = true;

            }
            catch (Exception e)
            {
                throw new OpcionMenuException();
            }
            return resultado;
        }

        public void CrearObjetoVehiculo(int opcion)
        {
            float velocidadMaxima = 0.0f;
            float velocidadMinima = 0.0f;
            string marca = "";
            string modelo ="";
            Vehiculo vehiculo = null;
            WriteLine("Ingrese la velocidad máxima");
            velocidadMaxima = float.Parse(ReadLine());
            WriteLine("Ingrese la velocidad mínima");
            velocidadMinima = float.Parse(ReadLine());
            WriteLine("Ingresa la marca");
            marca = ReadLine();
            WriteLine("Ingresa el modelo");
            modelo = ReadLine();

            if (opcion == 1)
            {
                vehiculo = new Avion(velocidadMaxima, velocidadMinima, Convert.ToDouble(duracion));
                ((Avion)vehiculo).Precio = precioLocal;
            }
        }
    }
}

