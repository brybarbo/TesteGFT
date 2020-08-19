using Bryan.TesteGFT.Domain.Interface;
using System;

namespace Bryan.TesteGFT.Domain.Models
{
    public class MediumRisk : IRisk
    {
        public MediumRisk(double valor, string setor)
        {
            _valor = valor;
            _setor = setor;
        }

        private double _valor { get; set; }
        private string _setor { get; set; }

        public string GetRisk()
        {
            return _valor > 1000000 && _setor.ToUpper() == "PUBLIC" ? "MEDIUMRISK" : "-";
        }
    }
}
