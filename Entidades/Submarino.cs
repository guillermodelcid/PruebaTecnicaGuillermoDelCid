namespace GuillermoDelCid.Entidades
{
    public class Submarino : Vehiculo
    {
        private float profundidadMaxima;

        public float ProfundidadMaxima
        {
            get { return profundidadMaxima; }
            set { profundidadMaxima = value; }
        }

        public Submarino() { }

        public Submarino(float metros) => (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo) =
        (velocidadMaxima, velocidadMinima, marca, modelo);



    }
}