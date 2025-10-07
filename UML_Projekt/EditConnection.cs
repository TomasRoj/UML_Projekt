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
    public partial class EditConnection : Form
    {
        public bool isDeleted { get; set; } = false;

        private Connection connection { get; set; }

        public EditConnection(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.textBoxStartMultiplicity.Text = this.textBoxStartMultiplicity.Text;
            this.textBoxEndMultiplicity.Text = this.textBoxEndMultiplicity.Text;

            this.connection.MultiplicityFrom = this.textBoxStartMultiplicity.Text;
            this.connection.MultiplicityTo = this.textBoxEndMultiplicity.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.isDeleted = true;
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connection.Reverse();
            this.DialogResult = DialogResult.OK;
        }
    }
}
