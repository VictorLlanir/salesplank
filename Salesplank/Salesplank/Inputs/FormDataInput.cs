namespace Salesplank.Inputs
{
    public class FormDataInput
    {
        public FormDataInput(string sponsorName, string sponsorLogo, string selectedModel, string numSponsors, string contact, bool generateEmail)
        {
            SponsorName = sponsorName;
            SponsorLogo = sponsorLogo;
            SelectedModel = selectedModel;
            NumSponsors = numSponsors;
            Contact = contact;
            GenerateEmail = generateEmail;
        }
        public string SponsorName { get; private set; }
        public string SponsorLogo { get; private set; }
        public string SelectedModel { get; private set; }
        public string NumSponsors { get; private set; }
        public string Contact { get; private set; }
        public bool GenerateEmail { get; private set; }
    }
}
