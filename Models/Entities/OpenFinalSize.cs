using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class OpenFinalSize
    {
        public int ID { get; set; }
        public int IdSection { get; set; }
        public bool OpenValue { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float PaperWidth { get; set; }
        public float PaperHeight { get; set; }
        public int YieldObtained { get; set; }
        public bool NUP { get; set; }
        public int NUp_Horizontal { get; set; }
        public int NUp_Vertical { get; set; }
        public bool NUp_Calculated_Horizontal { get; set; }
        public float MinWidth { get; set; }
        public float MaxWidth { get; set; }
        public float MinHeight { get; set; }
        public float MaxHeight { get; set; }

        public string Descrizione
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            string descrizione = string.Format("{0:N1} x {1:N1} cm", Width, Height);
            if (OpenValue)
            {
                descrizione = "Personalizzato...";
            }
            return descrizione;
        }
    }
}
