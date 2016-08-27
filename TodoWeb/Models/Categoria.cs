using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Categoria
    {

        public int CategoriaID { get; set; }
        public string Nome { get; set; }

        #region Chave Estrangeira
        public int UsuarioID { get; set; }
        #endregion
    }
}