using Bryan.TesteGFT.Domain.Interface;
using System;

namespace Bryan.TesteGFT.Domain.Models
{
    public class HighRisk : IRisk
    {
        public HighRisk(double valor, string setor)
        {
            _valor = valor;
            _setor = setor;
        }

        public double Value => _valor;
        public string ClientSector => _setor;

        private double _valor { get; set; }
        private string _setor { get; set; }

        public string GetRisk()
        {
            return Value > 1000000 && ClientSector.ToUpper() == "PRIVATE" ? "HIGHRISK" : "";
        }
    }
}
