namespace UML_Projekt
{
    partial class NewInterfaceForm
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
            methodDataTypeCombo.Items.AddRange(new object[] { "Date", "string", "int", "bool", "void" });
            methodDataTypeCombo.Location = new Point(223, 70);
            methodDataTypeCombo.Name = "methodDataTypeCombo";
            methodDataTypeCombo.Size = new Size(77, 23);
            methodDataTypeCombo.TabIndex = 30;
            // 
            // addMethodBTN
            // 
            addMethodBTN.Location = new Point(12, 103);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 29;
            addMethodBTN.Text = "Přidat metodu";
            addMethodBTN.UseVisualStyleBackColor = true;
            addMethodBTN.Click += addMethodBTN_Click_1;
            // 
            // methodAccessCombo
            // 
            methodAccessCombo.FormattingEnabled = true;
            methodAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            methodAccessCombo.Location = new Point(12, 70);
            methodAccessCombo.Name = "methodAccessCombo";
            methodAccessCombo.Size = new Size(39, 23);
            methodAccessCombo.TabIndex = 28;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(57, 69);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(160, 23);
            newMethodName.TabIndex = 27;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 26;
            label2.Text = "Nová metoda";
            // 
            // methodsListBox
            // 
            methodsListBox.FormattingEnabled = true;
            methodsListBox.ItemHeight = 15;
            methodsListBox.Location = new Point(8, 142);
            methodsListBox.Name = "methodsListBox";
            methodsListBox.Size = new Size(288, 124);
            methodsListBox.TabIndex = 22;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 17;
            nameTextBox.Text = "Jméno interface";
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(8, 280);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 16;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += confirmBTN_Click_1;
            // 
            // NewInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 315);
            Controls.Add(methodDataTypeCombo);
            Controls.Add(addMethodBTN);
            Controls.Add(methodAccessCombo);
            Controls.Add(newMethodName);
            Controls.Add(label2);
            Controls.Add(methodsListBox);
            Controls.Add(nameTextBox);
            Controls.Add(confirmBTN);
            Name = "NewInterfaceForm";
            Text = "Nový interface";
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