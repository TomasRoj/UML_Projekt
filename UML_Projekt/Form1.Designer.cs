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
            label1 = new Label();
            connectionSimpleBTN = new Button();
            connectionDashedBTN = new Button();
            connectionArrowBTN = new Button();
            button4 = new Button();
            button5 = new Button();
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
            DiagramBox.Paint += DiagramBox_Paint_1;
            DiagramBox.MouseClick += DiagramBox_MouseClick;
            DiagramBox.MouseDown += DiagramBox_MouseDown;
            DiagramBox.MouseMove += DiagramBox_MouseMove;
            DiagramBox.MouseUp += DiagramBox_MouseUp;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Propojení";
            // 
            // connectionSimpleBTN
            // 
            connectionSimpleBTN.Location = new Point(12, 74);
            connectionSimpleBTN.Name = "connectionSimpleBTN";
            connectionSimpleBTN.Size = new Size(149, 23);
            connectionSimpleBTN.TabIndex = 3;
            connectionSimpleBTN.Text = "Jednoduchá";
            connectionSimpleBTN.UseVisualStyleBackColor = true;
            connectionSimpleBTN.Click += connectionSimpleBTN_Click;
            // 
            // connectionDashedBTN
            // 
            connectionDashedBTN.Location = new Point(12, 103);
            connectionDashedBTN.Name = "connectionDashedBTN";
            connectionDashedBTN.Size = new Size(149, 23);
            connectionDashedBTN.TabIndex = 4;
            connectionDashedBTN.Text = "Čárkovaná";
            connectionDashedBTN.UseVisualStyleBackColor = true;
            connectionDashedBTN.Click += connectionDashedBTN_Click;
            // 
            // connectionArrowBTN
            // 
            connectionArrowBTN.Location = new Point(12, 132);
            connectionArrowBTN.Name = "connectionArrowBTN";
            connectionArrowBTN.Size = new Size(149, 23);
            connectionArrowBTN.TabIndex = 5;
            connectionArrowBTN.Text = "Šipka";
            connectionArrowBTN.UseVisualStyleBackColor = true;
            connectionArrowBTN.Click += connectionArrowBTN_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 161);
            button4.Name = "button4";
            button4.Size = new Size(149, 23);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 190);
            button5.Name = "button5";
            button5.Size = new Size(149, 23);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 637);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(connectionArrowBTN);
            Controls.Add(connectionDashedBTN);
            Controls.Add(connectionSimpleBTN);
            Controls.Add(label1);
            Controls.Add(addClassBTN);
            Controls.Add(DiagramBox);
            Name = "Form1";
            Text = "UML Projekt";
            ((System.ComponentModel.ISupportInitialize)DiagramBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DiagramBox;
        private Button addClassBTN;
        private Label label1;
        private Button connectionSimpleBTN;
        private Button connectionDashedBTN;
        private Button connectionArrowBTN;
        private Button button4;
        private Button button5;
    }
}
