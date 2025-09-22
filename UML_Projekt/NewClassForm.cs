using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UML_Projekt
{
    public partial class NewClassForm : Form
    {
        private List<UmlAtribute> createdAtributes = new List<UmlAtribute>();
        private List<UmlMethod> createdMethods = new List<UmlMethod>();

        public UmlClass CreatedClass { get; set; }

        public NewClassForm()
        {
            InitializeComponent();
        }

        private void atributeAddBTN_Click(object sender, EventArgs e)
        {
            string atrAccess = this.atributeAccessCombo.Text;
            string atrName = this.newAtributeName.Text;
            string atrType = this.atributeDataTypeCombo.Text;

            UmlAtribute newAtribute = new UmlAtribute(atrName, atrType, atrAccess);
            createdAtributes.Add(newAtribute);

            this.atributesListBox.Items.Add($"{atrAccess} {atrName} : {atrType}");

            this.atributeAccessCombo.Text = "";
            this.newAtributeName.Text = "";
            this.atributeDataTypeCombo.Text = "";

        }

        private void addMethodBTN_Click(object sender, EventArgs e)
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

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            string newClassName = this.nameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(newClassName))
            {
                bool isAbstract = this.abstractBTN.Checked;
                bool isStatic = this.staticBTN.Checked;

                UmlClass newClass = new UmlClass(newClassName, createdAtributes, createdMethods, isAbstract, isStatic);
                this.CreatedClass = newClass;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Název třídy nesmí být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
