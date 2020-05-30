using System;
using System.Collections.Generic;
using System.Text;

namespace TrashBoatASP.DTO
{
    public class ContenedorInteligente
    {
        public string idContenedor;
        private string ubicacion;
        private string nivelLlenado;
        private string ultimaDescarga;

        public string IdContenedor
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

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public string NivelLlenado
        {
            get
            {
                return nivelLlenado;
            }

            set
            {
                nivelLlenado = value;
            }
        }

        public string UltimaDescarga
        {
            get
            {
                return ultimaDescarga;
            }

            set
            {
                ultimaDescarga = value;
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
