using System;
using System.Collections.Generic;
using System.Text;

namespace TrashBoatASP.DTO
{
    public class ContenedorInteligente
    {
        private long idContenedor;
        private string nombreClave;
        private double capacidadActual;
        private double capacidadTotal;

       
    

        public long IdContenedor
        {
            get
            {
                return idContenedor;
            }

            set
            {
                idContenedor = value;
            }
        }

        public string NombreClave
        {
            get
            {
                return nombreClave;
            }

            set
            {
                nombreClave = value;
            }
        }

        public double CapacidadTotal
        {
            get
            {
                return capacidadTotal;
            }

            set
            {
                capacidadTotal = value;
            }
        }

        public double CapacidadActual
        {
            get
            {
                return capacidadActual;
            }

            set
            {
                capacidadActual = value;
            }
        }

        public void definirLlenado()
        {

        }
        public void trasladarContenedor()
        {

        }
    }
}
