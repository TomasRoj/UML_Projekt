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
    public partial class EditEnumForm : Form
    {
        public UmlEnum EditedEnum { get; set; }
        public List<string> CreatedValues { get; set; } = new List<string>();
        public EditEnumForm(UmlEnum umlEnum)
        {
            InitializeComponent();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            this.EditedEnum = new UmlEnum(this.nameTextBox.Text, this.CreatedValues);
            DialogResult = DialogResult.OK;
        }

        private void addMethodBTN_Click(object sender, EventArgs e)
        {
            this.CreatedValues.Add(this.newMethodName.Text);

            this.ValuesListBox.Items.Add(this.newMethodName.Text);
            this.newMethodName.Text = "";
        }
    }
}
