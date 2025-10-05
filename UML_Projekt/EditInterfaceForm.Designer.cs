namespace UML_Projekt
{
    partial class EditInterfaceForm
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
            methodDataTypeCombo = new ComboBox();
            addMethodBTN = new Button();
            methodAccessCombo = new ComboBox();
            newMethodName = new TextBox();
            label2 = new Label();
            methodsListBox = new ListBox();
            nameTextBox = new TextBox();
            confirmBTN = new Button();
            SuspendLayout();
            // 
            // methodDataTypeCombo
            // 
            methodDataTypeCombo.FormattingEnabled = true;
            methodDataTypeCombo.Items.AddRange(new object[] { "date", "String", "int" });
            methodDataTypeCombo.Location = new Point(218, 76);
            methodDataTypeCombo.Name = "methodDataTypeCombo";
            methodDataTypeCombo.Size = new Size(77, 23);
            methodDataTypeCombo.TabIndex = 38;
            // 
            // addMethodBTN
            // 
            addMethodBTN.Location = new Point(7, 109);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 37;
            addMethodBTN.Text = "Přidat metodu";
            addMethodBTN.UseVisualStyleBackColor = true;
            addMethodBTN.Click += addMethodBTN_Click;
            // 
            // methodAccessCombo
            // 
            methodAccessCombo.FormattingEnabled = true;
            methodAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            methodAccessCombo.Location = new Point(7, 76);
            methodAccessCombo.Name = "methodAccessCombo";
            methodAccessCombo.Size = new Size(39, 23);
            methodAccessCombo.TabIndex = 36;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(52, 75);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(160, 23);
            newMethodName.TabIndex = 35;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 34;
            label2.Text = "Nová metoda";
            // 
            // methodsListBox
            // 
            methodsListBox.FormattingEnabled = true;
            methodsListBox.ItemHeight = 15;
            methodsListBox.Location = new Point(3, 148);
            methodsListBox.Name = "methodsListBox";
            methodsListBox.Size = new Size(288, 124);
            methodsListBox.TabIndex = 33;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(7, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 32;
            nameTextBox.Text = "Jméno interface";
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(3, 286);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 31;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += confirmBTN_Click;
            // 
            // EditInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 331);
            Controls.Add(methodDataTypeCombo);
            Controls.Add(addMethodBTN);
            Controls.Add(methodAccessCombo);
            Controls.Add(newMethodName);
            Controls.Add(label2);
            Controls.Add(methodsListBox);
            Controls.Add(nameTextBox);
            Controls.Add(confirmBTN);
            Name = "EditInterfaceForm";
            Text = "Editace interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox methodDataTypeCombo;
        private Button addMethodBTN;
        private ComboBox methodAccessCombo;
        private TextBox newMethodName;
        private Label label2;
        private ListBox methodsListBox;
        private TextBox nameTextBox;
        private Button confirmBTN;
    }
}