using System;
using System.Collections.Generic;
using System.Text;

namespace TrashBoatASP.DTO
{
    public class ContenedorInteligente
    {
        private int idContenedor;
        private string nombreClave;
        private float capacidadActual;
        private float capacidadTotal;

       
    

        public int IdContenedor
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

        public float CapacidadTotal
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

        public float CapacidadActual
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
