using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Login { get; set; }

        public String Senha { get; set; }

    }
}
