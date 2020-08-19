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
            if (valor <= 1000000 && clientSector.ToUpper() == "PUBLIC")
                return "LOWRISK";
            else if (valor > 1000000 && clientSector.ToUpper() == "PUBLIC")
                return "MEDIUMRISK";
            else if (valor > 1000000 && clientSector.ToUpper() == "PRIVATE")
                return "HIGHRISK";

            return string.Empty;
        }
    }
}