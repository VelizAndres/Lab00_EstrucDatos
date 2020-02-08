using Lab00_AndresVeliz.Herramientas;

namespace Lab00_AndresVeliz.Models
{
    public class ClienteModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Descripcion { get; set; }






        public bool Save()
        {
            try
            {
                Almacen.Instance.ClientesMList.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
