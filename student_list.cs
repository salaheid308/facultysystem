using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faculty
{
    public partial class student_list : Form
    {
        faul db = new faul();
        public student_list()
        {
            InitializeComponent();
            dtg.DataSource = db.studint.ToList();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtg.DataSource = db.studint.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(ddl.SelectedValue.ToString());
            dtg.DataSource = db.studint.Where(v => v.name.Contains(txt_searsh.Text) && v.deb_id == k).ToList();
        }

        private void student_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faultyDataSet.debartments' table. You can move, or remove it, as needed.
            this.debartmentsTableAdapter.Fill(this.faultyDataSet.debartments);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = int.Parse(ddl.SelectedValue.ToString());
            dtg.DataSource = db.studint.Where(v => v.deb_id ==k).ToList();

        }
    }
}
