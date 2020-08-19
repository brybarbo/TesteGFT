namespace Bryan.TesteGFT.Domain.Models
{
    public class Trade : ITrade
    {
        public Trade(double valor, string clientSector)
        {
          _value  = valor;
         _clientSector = clientSector;
        }
        private double _value;
        private string _clientSector;


        public double Value => _value;
        public string ClientSector => _clientSector;
    }
}
