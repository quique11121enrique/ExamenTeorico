using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTeorico.Protuctos
{
    public class Datos
    {
        public string Nombre { get; set; }
        public string ID { get; set; }
        public string Precio { get; set; }

        public string Url { get; set; }
        public string Foto { get; set; }
        public string CodigoBarras { get; set; }
        public string Cantidad { get; set; }

        public override string ToString()
        {
            return ID;
        }
    }
}
