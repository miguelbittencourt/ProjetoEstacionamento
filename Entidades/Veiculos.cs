using System;

namespace Estacionamento.Entidades
{
    public class Veiculos
    {
        public int Id { get; set; }
        public string TipoVeiculo { get; set; }//carro ou moto
        public string Observacao { get; set; }// referencia do carro ou dono
        public string Marca { get; set; }// marca
        public string Cor { get; set; }// coloração

        public string Placa { get; set; }//dados da placa

        public string Dono { get; set; }//nome do dono

        public string Contato { get; set; }// contato para informar o dono qualquer problema

        public DateTime Chegada { get; set; }//hora de chegada a o estacionamento

        public DateTime Saida { get; set; } //saida do estacionamento

        public String Referencia { get; set; }//local do estacionamento

        public Boolean Status { get; set; }

        //Entrada para cadastro (Veículo, Modelo, Marca, cor, placa, Dono, Contato, Contato, Chegada, Saída, Referência, ativo) 
    }
}
