namespace UML_Projekt
{
    partial class Form1
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
            DiagramBox = new PictureBox();
            addClassBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)DiagramBox).BeginInit();
            SuspendLayout();
            // 
            // DiagramBox
            // 
            DiagramBox.Location = new Point(167, 12);
            DiagramBox.Name = "DiagramBox";
            DiagramBox.Size = new Size(952, 613);
            DiagramBox.TabIndex = 0;
            DiagramBox.TabStop = false;
            // 
            // addClassBTN
            // 
            addClassBTN.Location = new Point(12, 12);
            addClassBTN.Name = "addClassBTN";
            addClassBTN.Size = new Size(149, 30);
            addClassBTN.TabIndex = 1;
            addClassBTN.Text = "Nová class";
            addClassBTN.UseVisualStyleBackColor = true;
            addClassBTN.Click += addClassBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 637);
            Controls.Add(addClassBTN);
            Controls.Add(DiagramBox);
            Name = "Form1";
            Text = "UML Projekt";
            ((System.ComponentModel.ISupportInitialize)DiagramBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DiagramBox;
        private Button addClassBTN;
    }
}
