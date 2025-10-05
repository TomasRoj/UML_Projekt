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
    public partial class NewEnumForm : Form
    {
        public NewEnumForm()
        {
            InitializeComponent();
        }

        private List<string> createdValues = new List<string>();

        public UmlEnum createdEnum { get; set; }

        private void addMethodBTN_Click(object sender, EventArgs e)
        {
            string enumValue = this.newMethodName.Text;

            createdValues.Add(enumValue);

            this.ValuesListBox.Items.Add($"{enumValue}");
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            string newClassName = this.nameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(newClassName))
            {

                UmlEnum newEnum = new UmlEnum(newClassName, createdValues);
                this.createdEnum = newEnum;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Název enumu nesmí být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
