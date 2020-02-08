using Lab00_AndresVeliz.Models;
using System.Collections.Generic;

namespace Lab00_AndresVeliz.Herramientas
{
    public class Almacen
    {
        private static Almacen _instance = null;

        public static Almacen Instance
        {
            get
            {
                if (_instance == null) _instance = new Almacen();
                return _instance;
            }
        }

        public List<ClienteModel> ClientesMList = new List<ClienteModel>();

    }
}