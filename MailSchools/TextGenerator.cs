namespace MailSchools
{
    public class TextGenerator
    {
        private TextDatabase textDb;
        private SchoolDatabase schoolDb;

        public TextGenerator()
        {
        }

        public string GetText(ActivityType type)
        {
            string text = string.Empty;

            return text;
        }

        public void FinalizeText(Mail mail, User user, School school)
        {
            string text = mail.MailBody;

            text.Replace("Name", user.Name);
            text.Replace("Org", user.Organization);
            text.Replace("SchoolName", school.Name);

            mail.MailBody = text;
        }
    }
}
