using Bryan.TesteGFT.Domain.Interface;

namespace Bryan.TesteGFT.Domain.Models
{
    public class Trade : ITrade
    {
        public Trade(double valor, string clientSector)
        {
            Value = valor;
            ClientSector = clientSector;
        }

        public double Value { get; }
        public string ClientSector { get; }
    }
}
