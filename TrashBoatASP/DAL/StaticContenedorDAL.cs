using System;
using System.Collections.Generic;
using System.Text;
using TrashBoatASP.DTO;

namespace TrashBoatASP.DAL
{
    public class StaticContenedorDAL : ContenedorDAL
    {
    
        private static List<ContenedorInteligente> contenedores = new List<ContenedorInteligente>();


        public void actualizarContenedores(string id)
        {
            throw new NotImplementedException();
        }

        public void agregarContenedores(ContenedorInteligente contenedor)
        {
            contenedores.Add(contenedor); 
        }

        public ContenedorInteligente buscarContendores(int id)
        {
            
            return contenedores.Find(c => c.IdContenedor == id);

        }

        public void eliminarContenedores(string id)
        {
            throw new NotImplementedException();
        }

        public List<ContenedorInteligente> GetContenedorInteligentes()
        {
            return contenedores;
        }
        

    }
}
