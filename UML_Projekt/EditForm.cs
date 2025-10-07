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
    public partial class EditForm : Form
    {

        public UmlClass EditedClass { get; set; }
        public EditForm(UmlClass umlclass)
        {
            InitializeComponent();
            this.EditedClass = umlclass;
            this.nameTextBox.Text = umlclass.Name;
            this.atributesListBox.Items.AddRange(umlclass.Atributes.Select(a => $"{a.Visibility} {a.Name} : {a.Type}").ToArray());
            this.methodsListBox.Items.AddRange(umlclass.Methods.Select(m => $"{m.Visibility} {m.Name} : {m.Type}").ToArray());
            this.abstractBTN.Checked = umlclass.IsAbstract;
            this.staticBTN.Checked = umlclass.IsStatic;
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            UmlClass edited = new UmlClass(this.nameTextBox.Text, GetNewAtributes(), GetNewMethods(), this.abstractBTN.Checked, this.staticBTN.Checked);
            this.EditedClass = edited;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private List<UmlAtribute> GetNewAtributes()
        {
            return this.atributesListBox.Items.Cast<string>().Select(item =>
            {
                var trimmed = item.Trim();
                int firstSpace = trimmed.IndexOf(' ');
                string visibility = trimmed.Substring(0, firstSpace);
                string rest = trimmed.Substring(firstSpace + 1);
                var nameType = rest.Split(new[] { " : " }, StringSplitOptions.None);
                string name = nameType[0].Trim();
                string type = nameType.Length > 1 ? nameType[1].Trim() : "";
                return new UmlAtribute(name, type, visibility);
            }).ToList();
        }

        private List<UmlMethod> GetNewMethods()
        {
            return this.methodsListBox.Items.Cast<string>().Select(item =>
            {
                var trimmed = item.Trim();
                int firstSpace = trimmed.IndexOf(' ');
                string visibility = trimmed.Substring(0, firstSpace);
                string rest = trimmed.Substring(firstSpace + 1);
                var nameType = rest.Split(new[] { " : " }, StringSplitOptions.None);
                string name = nameType[0].Trim();
                string type = nameType.Length > 1 ? nameType[1].Trim() : "";
                return new UmlMethod(name, type, visibility);
            }).ToList();
        }

        private void atributeAddBTN_Click(object sender, EventArgs e)
        {
            string atrAccess = this.atributeAccessCombo.Text;
            string atrName = this.newAtributeName.Text;
            string atrType = this.atributeDataTypeCombo.Text;

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

            this.methodsListBox.Items.Add($"{methodAccess} {methodName} : {methodType}");

            this.methodAccessCombo.Text = "";
            this.newMethodName.Text = "";
            this.methodDataTypeCombo.Text = "";
        }

        private void btnDeleteAtribut_Click(object sender, EventArgs e)
        {
            this.atributeAccessCombo.Items.RemoveAt(this.atributeAccessCombo.SelectedIndex);
            this.EditedClass.Atributes = GetNewAtributes();
        }

        private void btnDeleteMethod_Click(object sender, EventArgs e)
        {
            this.methodAccessCombo.Items.RemoveAt(this.methodAccessCombo.SelectedIndex);
            this.methodAccessCombo.Refresh();
            this.EditedClass.Methods = GetNewMethods();
        }
    }
}
