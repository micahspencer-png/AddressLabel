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
            if (EvaluateFields() != "") 
            {
                MessageBox.Show(EvaluateFields());
            }

            else 
            {
                DisplayText.Text = $"{FirstNametextbox.Text} {LastNametextbox.Text} \n{StreetAddresstextbox.Text} \n{Citytextbox.Text}, {Statetextbox.Text} {Zipcodetextbox.Text}";
            }
        }

        string EvaluateFields() 
        {
            string message = "";

            if (Zipcodetextbox.Text == "")
            {
                Zipcodetextbox.Focus();
                message += "Zipcode is Required\n";
            }

            if (Statetextbox.Text == "")
            {
                Statetextbox.Focus();
                message += "State is Required\n";
            }

            if (Citytextbox.Text == "")
            {
                Citytextbox.Focus();
                message += "City is Required\n";
            }

            if (StreetAddresstextbox.Text == "")
            {
                StreetAddresstextbox.Focus();
                message += "Street Address is Required\n";
            }

            if (LastNametextbox.Text == "")
            {
                LastNametextbox.Focus();
                message += "Last Name is Required\n";
            }

            if (FirstNametextbox.Text == "")
            {
                FirstNametextbox.Focus();
                message += "First Name is Required\n";
            }

            string[] messageArray;
            messageArray = message.Split("\n");
            message = "";
            for (int i = messageArray.GetUpperBound(0); i >= 0; i--)
            {
                message += messageArray[i] + "\n";
            }

            return message;
        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {
            DisplayContent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayText.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
