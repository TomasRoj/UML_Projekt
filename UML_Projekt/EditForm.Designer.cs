namespace UML_Projekt
{
    partial class EditForm
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
            atributeDataTypeCombo = new ComboBox();
            methodDataTypeCombo = new ComboBox();
            addMethodBTN = new Button();
            methodAccessCombo = new ComboBox();
            newMethodName = new TextBox();
            label2 = new Label();
            atributeAddBTN = new Button();
            atributeAccessCombo = new ComboBox();
            newAtributeName = new TextBox();
            methodsListBox = new ListBox();
            label1 = new Label();
            atributesListBox = new ListBox();
            staticBTN = new RadioButton();
            abstractBTN = new RadioButton();
            nameTextBox = new TextBox();
            confirmBTN = new Button();
            btnDeleteAtribut = new Button();
            btnDeleteMethod = new Button();
            SuspendLayout();
            // 
            // atributeDataTypeCombo
            // 
            atributeDataTypeCombo.FormattingEnabled = true;
            atributeDataTypeCombo.Items.AddRange(new object[] { "date", "String", "int" });
            atributeDataTypeCombo.Location = new Point(224, 97);
            atributeDataTypeCombo.Name = "atributeDataTypeCombo";
            atributeDataTypeCombo.Size = new Size(77, 23);
            atributeDataTypeCombo.TabIndex = 31;
            // 
            // methodDataTypeCombo
            // 
            methodDataTypeCombo.FormattingEnabled = true;
            methodDataTypeCombo.Items.AddRange(new object[] { "date", "String", "int" });
            methodDataTypeCombo.Location = new Point(224, 186);
            methodDataTypeCombo.Name = "methodDataTypeCombo";
            methodDataTypeCombo.Size = new Size(77, 23);
            methodDataTypeCombo.TabIndex = 30;
            // 
            // addMethodBTN
            // 
            addMethodBTN.Location = new Point(13, 219);
            addMethodBTN.Name = "addMethodBTN";
            addMethodBTN.Size = new Size(288, 23);
            addMethodBTN.TabIndex = 29;
            addMethodBTN.Text = "Přidat metodu";
            addMethodBTN.UseVisualStyleBackColor = true;
            addMethodBTN.Click += addMethodBTN_Click;
            // 
            // methodAccessCombo
            // 
            methodAccessCombo.FormattingEnabled = true;
            methodAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            methodAccessCombo.Location = new Point(13, 186);
            methodAccessCombo.Name = "methodAccessCombo";
            methodAccessCombo.Size = new Size(39, 23);
            methodAccessCombo.TabIndex = 28;
            // 
            // newMethodName
            // 
            newMethodName.Location = new Point(58, 185);
            newMethodName.Name = "newMethodName";
            newMethodName.Size = new Size(160, 23);
            newMethodName.TabIndex = 27;
            newMethodName.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 167);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 26;
            label2.Text = "Nová metoda";
            // 
            // atributeAddBTN
            // 
            atributeAddBTN.Location = new Point(13, 131);
            atributeAddBTN.Name = "atributeAddBTN";
            atributeAddBTN.Size = new Size(288, 23);
            atributeAddBTN.TabIndex = 25;
            atributeAddBTN.Text = "Přidat atribut";
            atributeAddBTN.UseVisualStyleBackColor = true;
            atributeAddBTN.Click += atributeAddBTN_Click;
            // 
            // atributeAccessCombo
            // 
            atributeAccessCombo.FormattingEnabled = true;
            atributeAccessCombo.Items.AddRange(new object[] { "+", "-", "#", "~" });
            atributeAccessCombo.Location = new Point(13, 98);
            atributeAccessCombo.Name = "atributeAccessCombo";
            atributeAccessCombo.Size = new Size(39, 23);
            atributeAccessCombo.TabIndex = 24;
            // 
            // newAtributeName
            // 
            newAtributeName.Location = new Point(58, 97);
            newAtributeName.Name = "newAtributeName";
            newAtributeName.Size = new Size(160, 23);
            newAtributeName.TabIndex = 23;
            newAtributeName.Text = "Název";
            // 
            // methodsListBox
            // 
            methodsListBox.FormattingEnabled = true;
            methodsListBox.ItemHeight = 15;
            methodsListBox.Location = new Point(13, 396);
            methodsListBox.Name = "methodsListBox";
            methodsListBox.Size = new Size(288, 94);
            methodsListBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 79);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 21;
            label1.Text = "Nová vlastnost";
            // 
            // atributesListBox
            // 
            atributesListBox.FormattingEnabled = true;
            atributesListBox.ItemHeight = 15;
            atributesListBox.Location = new Point(13, 293);
            atributesListBox.Name = "atributesListBox";
            atributesListBox.Size = new Size(288, 94);
            atributesListBox.TabIndex = 20;
            // 
            // staticBTN
            // 
            staticBTN.AutoSize = true;
            staticBTN.Location = new Point(162, 42);
            staticBTN.Name = "staticBTN";
            staticBTN.Size = new Size(110, 19);
            staticBTN.TabIndex = 19;
            staticBTN.TabStop = true;
            staticBTN.Text = "Statická metoda";
            staticBTN.UseVisualStyleBackColor = true;
            // 
            // abstractBTN
            // 
            abstractBTN.AutoSize = true;
            abstractBTN.Location = new Point(33, 42);
            abstractBTN.Name = "abstractBTN";
            abstractBTN.Size = new Size(123, 19);
            abstractBTN.TabIndex = 18;
            abstractBTN.TabStop = true;
            abstractBTN.Text = "Abstraktní metoda";
            abstractBTN.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(13, 13);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 17;
            nameTextBox.Text = "Jméno třídy";
            // 
            // confirmBTN
            // 
            confirmBTN.ForeColor = SystemColors.Desktop;
            confirmBTN.Location = new Point(13, 496);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(288, 23);
            confirmBTN.TabIndex = 16;
            confirmBTN.Text = "Potvrdit";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += confirmBTN_Click;
            // 
            // btnDeleteAtribut
            // 
            btnDeleteAtribut.Location = new Point(13, 264);
            btnDeleteAtribut.Name = "btnDeleteAtribut";
            btnDeleteAtribut.Size = new Size(143, 23);
            btnDeleteAtribut.TabIndex = 32;
            btnDeleteAtribut.Text = "Smazat atribut";
            btnDeleteAtribut.UseVisualStyleBackColor = true;
            btnDeleteAtribut.Click += btnDeleteAtribut_Click;
            // 
            // btnDeleteMethod
            // 
            btnDeleteMethod.Location = new Point(158, 264);
            btnDeleteMethod.Name = "btnDeleteMethod";
            btnDeleteMethod.Size = new Size(143, 23);
            btnDeleteMethod.TabIndex = 33;
            btnDeleteMethod.Text = "Smazat metodu";
            btnDeleteMethod.UseVisualStyleBackColor = true;
            btnDeleteMethod.Click += btnDeleteMethod_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 530);
            Controls.Add(btnDeleteMethod);
            Controls.Add(btnDeleteAtribut);
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
            Name = "EditForm";
            Text = "Editovat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox atributeDataTypeCombo;
        private ComboBox methodDataTypeCombo;
        private Button addMethodBTN;
        private ComboBox methodAccessCombo;
        private TextBox newMethodName;
        private Label label2;
        private Button atributeAddBTN;
        private ComboBox atributeAccessCombo;
        private TextBox newAtributeName;
        private ListBox methodsListBox;
        private Label label1;
        private ListBox atributesListBox;
        private RadioButton staticBTN;
        private RadioButton abstractBTN;
        private TextBox nameTextBox;
        private Button confirmBTN;
        private Button btnDeleteAtribut;
        private Button btnDeleteMethod;
    }
}