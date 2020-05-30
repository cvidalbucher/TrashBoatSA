using System;
using System.Collections.Generic;
using System.Text;
using TrashBoatASP.DTO;

namespace TrashBoatASP.DAL
{
    interface contenedorDAL
    {
        // fALTA PUBLIC
        List<ContenedorInteligente> GetContenedorInteligentes();
        void agregarContenedores();
        void buscarContendores(string id);
        void actualizarContenedores(string id);
        void eliminarContenedores(string id);

    }
}
