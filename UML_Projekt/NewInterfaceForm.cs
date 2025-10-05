using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Projekt
{
    public partial class NewInterfaceForm : Form
    {
        public NewInterfaceForm()
        {
            InitializeComponent();
        }
        private List<UmlMethod> createdMethods = new List<UmlMethod>();

        public UmlInterface createdInterFace { get; set; }

        private void addMethodBTN_Click_1(object sender, EventArgs e)
        {
            string methodAccess = this.methodAccessCombo.Text;
            string methodName = this.newMethodName.Text;
            string methodType = this.methodDataTypeCombo.Text;

            UmlMethod newMethod = new UmlMethod(methodName, methodType, methodAccess);
            createdMethods.Add(newMethod);

            this.methodsListBox.Items.Add($"{methodAccess} {methodName} : {methodType}");

            this.methodAccessCombo.Text = "";
            this.newMethodName.Text = "";
            this.methodDataTypeCombo.Text = "";
        }

        private void confirmBTN_Click_1(object sender, EventArgs e)
        {
            string newClassName = this.nameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(newClassName))
            {

                UmlInterface newInterface = new UmlInterface(newClassName, createdMethods);
                this.createdInterFace = newInterface;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Název interface nesmí být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
