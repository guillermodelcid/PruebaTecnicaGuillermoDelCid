using System;

namespace GuillermoDelCid.Excepciones
{
    public class OpcionMenuException : Exception
    {

        private string message = "Error, \ndebe ingresar una opción válida";
        public override string Message
        {
            get { return message; }

        }

    }
}