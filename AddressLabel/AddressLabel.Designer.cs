namespace AddressLabel
{
    partial class AddressLabel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            FirstNametextbox = new TextBox();
            DisplayText = new Label();
            label2 = new Label();
            LastNametextbox = new TextBox();
            label3 = new Label();
            StreetAddresstextbox = new TextBox();
            label4 = new Label();
            Citytextbox = new TextBox();
            label5 = new Label();
            Statetextbox = new TextBox();
            label6 = new Label();
            Zipcodetextbox = new TextBox();
            Exit = new Button();
            Clear = new Button();
            DisplayLabel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstNametextbox
            // 
            FirstNametextbox.Location = new Point(41, 72);
            FirstNametextbox.Name = "FirstNametextbox";
            FirstNametextbox.Size = new Size(181, 27);
            FirstNametextbox.TabIndex = 1;
            // 
            // DisplayText
            // 
            DisplayText.BorderStyle = BorderStyle.FixedSingle;
            DisplayText.Font = new Font("Times New Roman", 20F);
            DisplayText.Location = new Point(340, 49);
            DisplayText.MaximumSize = new Size(1000, 1000);
            DisplayText.Name = "DisplayText";
            DisplayText.Size = new Size(416, 284);
            DisplayText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // LastNametextbox
            // 
            LastNametextbox.Location = new Point(41, 136);
            LastNametextbox.Name = "LastNametextbox";
            LastNametextbox.Size = new Size(181, 27);
            LastNametextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 166);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Street Address";
            // 
            // StreetAddresstextbox
            // 
            StreetAddresstextbox.Location = new Point(41, 189);
            StreetAddresstextbox.Name = "StreetAddresstextbox";
            StreetAddresstextbox.Size = new Size(181, 27);
            StreetAddresstextbox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 227);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 0;
            label4.Text = "City";
            // 
            // Citytextbox
            // 
            Citytextbox.Location = new Point(41, 250);
            Citytextbox.Name = "Citytextbox";
            Citytextbox.Size = new Size(181, 27);
            Citytextbox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 280);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 0;
            label5.Text = "State";
            // 
            // Statetextbox
            // 
            Statetextbox.Location = new Point(41, 303);
            Statetextbox.Name = "Statetextbox";
            Statetextbox.Size = new Size(181, 27);
            Statetextbox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 333);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 0;
            label6.Text = "Zipcode";
            // 
            // Zipcodetextbox
            // 
            Zipcodetextbox.Location = new Point(41, 356);
            Zipcodetextbox.Name = "Zipcodetextbox";
            Zipcodetextbox.Size = new Size(181, 27);
            Zipcodetextbox.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.Location = new Point(655, 389);
            Exit.Name = "Exit";
            Exit.Size = new Size(133, 49);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(516, 389);
            Clear.Name = "Clear";
            Clear.Size = new Size(133, 49);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // DisplayLabel
            // 
            DisplayLabel.Location = new Point(377, 389);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(133, 49);
            DisplayLabel.TabIndex = 3;
            DisplayLabel.Text = "Display Label";
            DisplayLabel.UseVisualStyleBackColor = true;
            DisplayLabel.Click += DisplayLabel_Click;
            // 
            // AddressLabel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayLabel);
            Controls.Add(Clear);
            Controls.Add(Exit);
            Controls.Add(DisplayText);
            Controls.Add(Zipcodetextbox);
            Controls.Add(label6);
            Controls.Add(Statetextbox);
            Controls.Add(label5);
            Controls.Add(Citytextbox);
            Controls.Add(label4);
            Controls.Add(StreetAddresstextbox);
            Controls.Add(label3);
            Controls.Add(LastNametextbox);
            Controls.Add(label2);
            Controls.Add(FirstNametextbox);
            Controls.Add(label1);
            Name = "AddressLabel";
            Text = "Address Label";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstNametextbox;
        private Label DisplayText;
        private Label label2;
        private TextBox LastNametextbox;
        private Label label3;
        private TextBox StreetAddresstextbox;
        private Label label4;
        private TextBox Citytextbox;
        private Label label5;
        private TextBox Statetextbox;
        private Label label6;
        private TextBox Zipcodetextbox;
        private Button Exit;
        private Button Clear;
        private Button DisplayLabel;
    }
}
