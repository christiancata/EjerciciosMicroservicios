namespace Ejercicio2.Clases
{
    public class Hueso : IComparable<Hueso>
    {
        #region Propiedades
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Densidad { get; set; }
        public double Longitud { get; set; }
        public double Diametro { get; set; }
        #endregion
        #region Constructores
        public Hueso(string nombre, double peso, double densidad, double longitud, double diametro)
        {
            Nombre = nombre;
            Peso = peso;
            Densidad = densidad;
            Longitud = longitud;
            Diametro = diametro;
        }
        #endregion
        #region Metodos
        int IComparable<Hueso>.CompareTo(Hueso? other)
        {
            int result = 0;

            if (other != null)
            {
                result = string.Compare(Nombre, other.Nombre, StringComparison.Ordinal);
            }

            return result;
        }
        #endregion
    }
}