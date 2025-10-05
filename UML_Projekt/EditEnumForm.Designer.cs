namespace UML_Projekt
{
    partial class EditEnumForm
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
            addMethodBTN.Location = new Point(12, 109);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 43;
            addMethodBTN.Text = "Přidat hodnotu";
            addMethodBTN.UseVisualStyleBackColor = true;
            addMethodBTN.Click += addMethodBTN_Click;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(12, 75);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(284, 23);
            newMethodName.TabIndex = 42;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 41;
            label2.Text = "Nová hodnota";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(8, 148);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(288, 124);
            ValuesListBox.TabIndex = 40;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 39;
            nameTextBox.Text = "Jméno enumu";
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(8, 286);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 38;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += confirmBTN_Click;
            // 
            // EditEnumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 323);
            Controls.Add(addMethodBTN);
            Controls.Add(newMethodName);
            Controls.Add(label2);
            Controls.Add(ValuesListBox);
            Controls.Add(nameTextBox);
            Controls.Add(confirmBTN);
            Name = "EditEnumForm";
            Text = "Editace enumu";
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