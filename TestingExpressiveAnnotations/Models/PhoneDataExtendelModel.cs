using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExpressiveAnnotations.Attributes;

namespace TestingExpressiveAnnotations.Models
{
    public class PhoneDataExtendelModel
    {
        public bool Comprobacion {
            get { return true; }
            set { Comprobacion = value; }
        }

        [RequiredIf("Comprobacion == true")]
        public string Description { get; set; }

        [RequiredIf("Comprobacion == true")]
        public string Numero { get; set; }
    }
}