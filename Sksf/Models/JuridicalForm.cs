namespace Sksf.Models
{
    public enum JuridicalForm : byte
    {
        State,
        /// <summary>
        /// Grevskapsråd
        /// </summary>
        CountryCouncil,

        Municipical,
        MunicipalAssociation,

        LimitedPartnerships,
        NonBankingCompany,
        NonHousingOrganization,

        NonProfits,
        OtherFoundations,
        
        ReligiousCommunities,

        NotSet = 0,
    }
}
