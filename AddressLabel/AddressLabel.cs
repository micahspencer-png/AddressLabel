namespace AddressLabel
{
    public partial class AddressLabel : Form
    {
        public AddressLabel()
        {
            InitializeComponent();
        }

        void DisplayContent() 
        { 
        
        }

        string EvaluateFields() 
        {
            string message = "";


            return message;
        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {
            DisplayContent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
