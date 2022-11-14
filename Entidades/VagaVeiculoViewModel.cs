using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Entidades
{
    public class VagaVeiculoViewModel
    {
        public Vagas Vagas { get; set; }
        public Veiculos? Veiculo { get; set; }
    }
}
