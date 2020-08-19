namespace Api.Common.Repository.Contracts.Core.Entities
{
    public interface ITrade
    {
        double Valor { get; }
        string ClientSector { get; }
    }
}
