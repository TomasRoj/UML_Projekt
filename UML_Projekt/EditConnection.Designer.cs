namespace UML_Projekt
{
    partial class EditConnection
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxStartMultiplicity = new TextBox();
            textBoxEndMultiplicity = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 18);
            button1.Name = "button1";
            button1.Size = new Size(247, 36);
            button1.TabIndex = 0;
            button1.Text = "Prohodit směr";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 60);
            button2.Name = "button2";
            button2.Size = new Size(247, 36);
            button2.TabIndex = 1;
            button2.Text = "Smazat propojení";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 109);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Multiplicita začátek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 177);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Multiplicita konec";
            // 
            // textBoxStartMultiplicity
            // 
            textBoxStartMultiplicity.Location = new Point(17, 138);
            textBoxStartMultiplicity.Name = "textBoxStartMultiplicity";
            textBoxStartMultiplicity.Size = new Size(245, 23);
            textBoxStartMultiplicity.TabIndex = 4;
            textBoxStartMultiplicity.Text = "Hodnota";
            // 
            // textBoxEndMultiplicity
            // 
            textBoxEndMultiplicity.Location = new Point(15, 195);
            textBoxEndMultiplicity.Name = "textBoxEndMultiplicity";
            textBoxEndMultiplicity.Size = new Size(247, 23);
            textBoxEndMultiplicity.TabIndex = 5;
            textBoxEndMultiplicity.Text = "Hodnota";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(15, 262);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(247, 47);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Potvrdit";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // EditConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 321);
            Controls.Add(btnConfirm);
            Controls.Add(textBoxEndMultiplicity);
            Controls.Add(textBoxStartMultiplicity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditConnection";
            Text = "Editace propojení";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBoxStartMultiplicity;
        private TextBox textBoxEndMultiplicity;
        private Button btnConfirm;
    }
}