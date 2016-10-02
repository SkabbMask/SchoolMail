namespace MailSchools
{
    /// <summary>
    /// This is how the actual spreadsheet looks like
    /// </summary>
    public class SchoolRow
    {
        public string HUVUDMANNATYP { get; set; }
        public int ORGANISATIONSNR { get; set; }
        public int LÄN { get; set; }
        public string LÄNSNAMN { get; set; }
        public int KOMMUN { get; set; }
        public string KOMMUNNAMN { get; set; }
        public int SKOLENHETSKOD { get; set; }
        public string NAMN { get; set; }
        public string ADRESS { get; set; }
        public int POSTNR { get; set; }
        public string POSTORT { get; set; }
        public string BESÖKSADRESS { get; set; }
        public int BESÖKSPOSTNR { get; set; }
        public string BESÖKSPOSTORT { get; set; }
        public string TELENR { get; set; }
        public string WEBB { get; set; }
        public string EPOST { get; set; }
        /// <summary>
        /// Bools are in "N" and "J" in db
        /// </summary>
        public bool FKLASS { get; set; }
        public bool ÅR1 { get; set; }
        public bool ÅR2 { get; set; }
        public bool ÅR3 { get; set; }
        public bool ÅR4 { get; set; }
        public bool ÅR5 { get; set; }
        public bool ÅR6 { get; set; }
        public bool ÅR7 { get; set; }
        public bool ÅR8 { get; set; }
        public bool ÅR9 { get; set; }
        public string HUVUDMANS_NAMN { get; set; }
        public string REKTORNS_NAMN { get; set; }
        public int ELEVAR_FKLASS { get; set; }
        public int ELEVER_ÅR1 { get; set; }
        public int ELEVER_ÅR2 { get; set; }
        public int ELEVER_ÅR3 { get; set; }
        public int ELEVER_ÅR4 { get; set; }
        public int ELEVER_ÅR5 { get; set; }
        public int ELEVER_ÅR6 { get; set; }
        public int ELEVER_ÅR7 { get; set; }
        public int ELEVER_ÅR8 { get; set; }
        public int ELEVER_ÅR9 { get; set; }
        public string INRIKTNING { get; set; }
        public string JURIDISK_FORM { get; set; }
    }
}
