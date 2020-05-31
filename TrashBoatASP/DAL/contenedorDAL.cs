using System;
using System.Collections.Generic;
using System.Text;
using TrashBoatASP.DTO;

namespace TrashBoatASP.DAL
{
    interface ContenedorDAL
    {
        // fALTA PUBLIC
        List<ContenedorInteligente> GetContenedorInteligentes();
        void agregarContenedores(ContenedorInteligente contenedor);
        ContenedorInteligente buscarContendores(string id);
        void actualizarContenedores(string id);
        void eliminarContenedores(string id);

    }
}
