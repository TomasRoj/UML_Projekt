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
            addInterfaceBTN = new Button();
            addEnumBTN = new Button();
            button1 = new Button();
            btnExport = new Button();
            btnImport = new Button();
            btnExportPNG = new Button();
            btnExportCode = new Button();
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
            DiagramBox.MouseDoubleClick += DiagramBox_MouseDoubleClick;
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
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Propojení";
            // 
            // connectionSimpleBTN
            // 
            connectionSimpleBTN.Location = new Point(12, 158);
            connectionSimpleBTN.Name = "connectionSimpleBTN";
            connectionSimpleBTN.Size = new Size(149, 23);
            connectionSimpleBTN.TabIndex = 3;
            connectionSimpleBTN.Text = "Asociace";
            connectionSimpleBTN.UseVisualStyleBackColor = true;
            connectionSimpleBTN.Click += connectionSimpleBTN_Click;
            // 
            // connectionDashedBTN
            // 
            connectionDashedBTN.Location = new Point(12, 187);
            connectionDashedBTN.Name = "connectionDashedBTN";
            connectionDashedBTN.Size = new Size(149, 23);
            connectionDashedBTN.TabIndex = 4;
            connectionDashedBTN.Text = "Agregace";
            connectionDashedBTN.UseVisualStyleBackColor = true;
            connectionDashedBTN.Click += connectionDashedBTN_Click;
            // 
            // connectionArrowBTN
            // 
            connectionArrowBTN.Location = new Point(12, 216);
            connectionArrowBTN.Name = "connectionArrowBTN";
            connectionArrowBTN.Size = new Size(149, 23);
            connectionArrowBTN.TabIndex = 5;
            connectionArrowBTN.Text = "Kompozice";
            connectionArrowBTN.UseVisualStyleBackColor = true;
            connectionArrowBTN.Click += connectionArrowBTN_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 245);
            button4.Name = "button4";
            button4.Size = new Size(149, 23);
            button4.TabIndex = 6;
            button4.Text = "Dědičnost";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 274);
            button5.Name = "button5";
            button5.Size = new Size(149, 23);
            button5.TabIndex = 7;
            button5.Text = "Realizace";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // addInterfaceBTN
            // 
            addInterfaceBTN.Location = new Point(12, 48);
            addInterfaceBTN.Name = "addInterfaceBTN";
            addInterfaceBTN.Size = new Size(149, 30);
            addInterfaceBTN.TabIndex = 8;
            addInterfaceBTN.Text = "Nový interface";
            addInterfaceBTN.UseVisualStyleBackColor = true;
            addInterfaceBTN.Click += addInterfaceBTN_Click;
            // 
            // addEnumBTN
            // 
            addEnumBTN.Location = new Point(12, 84);
            addEnumBTN.Name = "addEnumBTN";
            addEnumBTN.Size = new Size(149, 30);
            addEnumBTN.TabIndex = 9;
            addEnumBTN.Text = "Nový enum";
            addEnumBTN.UseVisualStyleBackColor = true;
            addEnumBTN.Click += addEnumBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 303);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 10;
            button1.Text = "Závislost";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 515);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(149, 23);
            btnExport.TabIndex = 11;
            btnExport.Text = "Uložit";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(12, 544);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(149, 23);
            btnImport.TabIndex = 12;
            btnImport.Text = "Načíst";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExportPNG
            // 
            btnExportPNG.Location = new Point(12, 573);
            btnExportPNG.Name = "btnExportPNG";
            btnExportPNG.Size = new Size(149, 23);
            btnExportPNG.TabIndex = 13;
            btnExportPNG.Text = "Export PNG";
            btnExportPNG.UseVisualStyleBackColor = true;
            btnExportPNG.Click += btnExportPNG_Click;
            // 
            // btnExportCode
            // 
            btnExportCode.Location = new Point(12, 602);
            btnExportCode.Name = "btnExportCode";
            btnExportCode.Size = new Size(149, 23);
            btnExportCode.TabIndex = 14;
            btnExportCode.Text = "Export C#";
            btnExportCode.UseVisualStyleBackColor = true;
            btnExportCode.Click += btnExportCode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 637);
            Controls.Add(btnExportCode);
            Controls.Add(btnExportPNG);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(button1);
            Controls.Add(addEnumBTN);
            Controls.Add(addInterfaceBTN);
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
            Load += Form1_Load;
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
        private Button addInterfaceBTN;
        private Button addEnumBTN;
        private Button button1;
        private Button btnExport;
        private Button btnImport;
        private Button btnExportPNG;
        private Button btnExportCode;
    }
}
