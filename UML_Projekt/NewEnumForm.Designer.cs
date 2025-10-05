namespace UML_Projekt
{
    partial class NewEnumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addMethodBTN = new Button();
            newMethodName = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            nameTextBox = new TextBox();
            confirmBTN = new Button();
            SuspendLayout();
            // 
            // addMethodBTN
            // 
            addMethodBTN.Location = new Point(12, 108);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 37;
            addMethodBTN.Text = "Přidat hodnotu";
            addMethodBTN.UseVisualStyleBackColor = true;
            addMethodBTN.Click += addMethodBTN_Click;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(12, 74);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(284, 23);
            newMethodName.TabIndex = 35;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 34;
            label2.Text = "Nová hodnota";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(8, 147);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(288, 124);
            ValuesListBox.TabIndex = 33;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 11);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 32;
            nameTextBox.Text = "Jméno enumu";
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(8, 285);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 31;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += confirmBTN_Click;
            // 
            // NewEnumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 321);
            Controls.Add(addMethodBTN);
            Controls.Add(newMethodName);
            Controls.Add(label2);
            Controls.Add(ValuesListBox);
            Controls.Add(nameTextBox);
            Controls.Add(confirmBTN);
            Name = "NewEnumForm";
            RightToLeftLayout = true;
            Text = "Nový Enum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addMethodBTN;
        private TextBox newMethodName;
        private Label label2;
        private ListBox ValuesListBox;
        private TextBox nameTextBox;
        private Button confirmBTN;
    }
}