using Api.Common.Repository.Contracts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bryan.TesteGFT.Domain.Models
{
    public class Trade : ITrade
    {
        public Trade(double valor, string clientSector)
        {
            Valor = valor;
            ClientSector = clientSector;
        }

        public double Valor { get; private set; }

        public string ClientSector { get; private set; }
    }
}
