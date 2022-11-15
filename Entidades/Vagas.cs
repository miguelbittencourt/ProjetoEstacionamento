using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Entidades

{
    public class Vagas
    {
        [Key()]
        public int Id { get; set; }
        public string Sigla { get; set; }
        [ForeignKey("Veiculos")]
        public int? VeiculoId { get; set; }
        public virtual Veiculos Veiculo { get; set; }
        public DateTime? Chegada { get; set; }//hora de chegada a o estacionamento
        public DateTime? Saida { get; set; } //saida do estacionamento
        public string Status { get; set; }
    }
}
