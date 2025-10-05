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
    public partial class EditInterfaceForm : Form
    {
        public UmlInterface EditedInterface { get; set; }
        public List<UmlMethod> newMethods { get; set; } = new List<UmlMethod>();

        public EditInterfaceForm(UmlInterface umlInterface)
        {
            InitializeComponent();

        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            this.EditedInterface = new UmlInterface(this.nameTextBox.Text, this.newMethods);
            DialogResult = DialogResult.OK;
        }

        private void addMethodBTN_Click(object sender, EventArgs e)
        {
            string methodAccess = this.methodAccessCombo.Text;
            string methodName = this.newMethodName.Text;
            string methodType = this.methodDataTypeCombo.Text;

            this.methodsListBox.Items.Add($"{methodAccess} {methodName} : {methodType}");
            this.newMethods.Add(new UmlMethod(methodName, methodType, methodAccess));

            this.methodAccessCombo.Text = "";
            this.newMethodName.Text = "";
            this.methodDataTypeCombo.Text = "";
            this.methodsListBox.Items.Add(this.newMethodName.Text);
        }
    }
}
