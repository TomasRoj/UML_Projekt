namespace UML_Projekt
{
    partial class NewClassForm
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
            confirmBTN = new Button();
            nameTextBox = new TextBox();
            abstractBTN = new RadioButton();
            staticBTN = new RadioButton();
            atributesListBox = new ListBox();
            label1 = new Label();
            methodsListBox = new ListBox();
            newAtributeName = new TextBox();
            atributeAccessCombo = new ComboBox();
            atributeAddBTN = new Button();
            addMethodBTN = new Button();
            methodAccessCombo = new ComboBox();
            newMethodName = new TextBox();
            label2 = new Label();
            methodDataTypeCombo = new ComboBox();
            atributeDataTypeCombo = new ComboBox();
            SuspendLayout();
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(12, 495);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 0;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.Text = "Jméno třídy";
            // 
            // abstractBTN
            // 
            abstractBTN.AutoSize = true;
            abstractBTN.Location = new Point(32, 41);
            abstractBTN.Name = "abstractBTN";
            abstractBTN.Size = new Size(123, 19);
            abstractBTN.TabIndex = 2;
            abstractBTN.TabStop = true;
            abstractBTN.Text = "Abstraktní metoda";
            abstractBTN.UseVisualStyleBackColor = true;
            // 
            // staticBTN
            // 
            staticBTN.AutoSize = true;
            staticBTN.Location = new Point(161, 41);
            staticBTN.Name = "staticBTN";
            staticBTN.Size = new Size(110, 19);
            staticBTN.TabIndex = 3;
            staticBTN.TabStop = true;
            staticBTN.Text = "Statická metoda";
            staticBTN.UseVisualStyleBackColor = true;
            // 
            // atributesListBox
            // 
            atributesListBox.FormattingEnabled = true;
            atributesListBox.ItemHeight = 15;
            atributesListBox.Location = new Point(12, 292);
            atributesListBox.Name = "atributesListBox";
            atributesListBox.Size = new Size(288, 94);
            atributesListBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "Nová vlastnost";
            // 
            // methodsListBox
            // 
            methodsListBox.FormattingEnabled = true;
            methodsListBox.ItemHeight = 15;
            methodsListBox.Location = new Point(12, 395);
            methodsListBox.Name = "methodsListBox";
            methodsListBox.Size = new Size(288, 94);
            methodsListBox.TabIndex = 6;
            // 
            // newAtributeName
            // 
            newAtributeName.Location = new Point(57, 96);
            newAtributeName.Name = "newAtributeName";
            newAtributeName.Size = new Size(160, 23);
            newAtributeName.TabIndex = 7;
            newAtributeName.Text = "Název";
            // 
            // atributeAccessCombo
            // 
            atributeAccessCombo.FormattingEnabled = true;
            atributeAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            atributeAccessCombo.Location = new Point(12, 97);
            atributeAccessCombo.Name = "atributeAccessCombo";
            atributeAccessCombo.Size = new Size(39, 23);
            atributeAccessCombo.TabIndex = 8;
            // 
            // atributeAddBTN
            // 
            atributeAddBTN.Location = new Point(12, 130);
            atributeAddBTN.Name = "atributeAddBTN";
            atributeAddBTN.Size = new Size(288, 23);
            atributeAddBTN.TabIndex = 9;
            atributeAddBTN.Text = "Přidat atribut";
            atributeAddBTN.UseVisualStyleBackColor = true;
            // 
            // addMethodBTN
            // 
            addMethodBTN.Location = new Point(12, 218);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 13;
            addMethodBTN.Text = "Přidat atribut";
            addMethodBTN.UseVisualStyleBackColor = true;
            // 
            // methodAccessCombo
            // 
            methodAccessCombo.FormattingEnabled = true;
            methodAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            methodAccessCombo.Location = new Point(12, 185);
            methodAccessCombo.Name = "methodAccessCombo";
            methodAccessCombo.Size = new Size(39, 23);
            methodAccessCombo.TabIndex = 12;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(57, 184);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(160, 23);
            newMethodName.TabIndex = 11;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Nová metoda";
            // 
            // methodDataTypeCombo
            // 
            methodDataTypeCombo.FormattingEnabled = true;
            methodDataTypeCombo.Items.AddRange(new object[] { "date", "String", "int" });
            methodDataTypeCombo.Location = new Point(223, 185);
            methodDataTypeCombo.Name = "methodDataTypeCombo";
            methodDataTypeCombo.Size = new Size(77, 23);
            methodDataTypeCombo.TabIndex = 14;
            // 
            // atributeDataTypeCombo
            // 
            atributeDataTypeCombo.FormattingEnabled = true;
            atributeDataTypeCombo.Items.AddRange(new object[] { "date", "String", "int" });
            atributeDataTypeCombo.Location = new Point(223, 96);
            atributeDataTypeCombo.Name = "atributeDataTypeCombo";
            atributeDataTypeCombo.Size = new Size(77, 23);
            atributeDataTypeCombo.TabIndex = 15;
            // 
            // NewClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 525);
            Controls.Add(atributeDataTypeCombo);
            Controls.Add(methodDataTypeCombo);
            Controls.Add(addMethodBTN);
            Controls.Add(methodAccessCombo);
            Controls.Add(newMethodName);
            Controls.Add(label2);
            Controls.Add(atributeAddBTN);
            Controls.Add(atributeAccessCombo);
            Controls.Add(newAtributeName);
            Controls.Add(methodsListBox);
            Controls.Add(label1);
            Controls.Add(atributesListBox);
            Controls.Add(staticBTN);
            Controls.Add(abstractBTN);
            Controls.Add(nameTextBox);
            Controls.Add(confirmBTN);
            Name = "NewClassForm";
            Text = "Nová class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmBTN;
        private TextBox nameTextBox;
        private RadioButton abstractBTN;
        private RadioButton staticBTN;
        private ListBox atributesListBox;
        private Label label1;
        private ListBox methodsListBox;
        private TextBox newAtributeName;
        private ComboBox atributeAccessCombo;
        private Button atributeAddBTN;
        private Button addMethodBTN;
        private ComboBox methodAccessCombo;
        private TextBox newMethodName;
        private Label label2;
        private ComboBox methodDataTypeCombo;
        private ComboBox atributeDataTypeCombo;
    }
}