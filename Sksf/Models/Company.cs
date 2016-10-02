namespace Sksf.Models
{
    public class Company
    {
        public int Id { get; set; }
        public CompanyKind Kind { get; set; }
        public SchoolKinds SchoolKinds { get; set; }
        public string Name { get; set; }
        public string PostalAdress { get; set; }
        public int PostalNumber { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public JuridicalForm JuridicalForm { get; set; }
    }
}
