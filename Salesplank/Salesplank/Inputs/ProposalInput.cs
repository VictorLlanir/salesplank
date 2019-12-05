namespace Salesplank.Inputs
{
    public class ProposalInput
    {
        public ProposalInput() { }
        public ProposalInput(string path, FormDataInput formDataInput)
        {
            Path = path;
            FormDataInput = formDataInput;
        }

        public string Path { get; private set; }
        public FormDataInput FormDataInput { get; private set; }
    }
}
