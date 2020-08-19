using Bryan.TesteGFT.Domain.Models;

namespace Bryan.TesteGFT.ApplicationService.ViewModels
{
    public class TradeCategoryViewModel
    {
        public TradeCategoryViewModel(double valor, string clientSector)
        {
            Category = GetCategory(valor, clientSector);
        }

        public string Category { get; }

        public string GetCategory(double valor, string clientSector)
        {
            var risk = RiskFactory.GetRiskDefination(valor, clientSector);
            return risk.GetRisk();
        }
    }
}