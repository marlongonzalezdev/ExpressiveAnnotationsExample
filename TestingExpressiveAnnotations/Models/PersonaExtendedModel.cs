using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingExpressiveAnnotations.Models
{
    public class PersonaExtendedModel
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
      
        public PhoneDataExtendelModel PhoneData { get; set; }
    }
}