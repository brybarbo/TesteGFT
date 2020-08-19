using Bryan.TesteGFT.Domain.Interface;

namespace Bryan.TesteGFT.Domain.Models
{
    public static class RiskFactory
    {
        public static IRisk GetRiskDefination(double valor, string clientSector)
        {
            switch (clientSector)
            {
                case "Public":
                    if (valor > 1000000) return new MediumRisk(valor, clientSector);
                    return new LowRisk(valor, clientSector);

                case "Private":                 
                    return new HighRisk(valor, clientSector);

                default:
                    return new LowRisk(valor, clientSector);
            }
        }
    }
}
