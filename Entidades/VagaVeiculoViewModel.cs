using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Entidades
{
    public class VagaVeiculoViewModel
    {
        public Vagas Vaga { get; set; }
        public List<Veiculos>? Veiculos { get; set; }
    }
}
