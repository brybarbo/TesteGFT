namespace Api.Common.Core.Authentication
{
    public class TokenConfigurations
    {
        public string Audience => "BBCE.Companies.Audience";
        public string Issuer => "BBCE.Companies.Issuer";
        public int Seconds => 86399;
    }
}