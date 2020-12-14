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
    public partial class Form1 : Form
    {

        faul db = new faul();
        
        public Form1()

        {  
            InitializeComponent();
            
        }

        private void btnsave_Click
            (object sender, EventArgs e)
        {
            if (txtname.Text == "" ||  txtage.Text == "" || txtadrs.Text == "")
            {
                MessageBox.Show("no data ");
                return;
            }
            add_studentdata();
            clear();
        }

        private void clear()
        {
            txtname.Text = "";
            txtage.Text = "";
            txtadrs.Text = "";
        }

        private void add_studentdata()
        {
            studint s = new studint();
            s.name = txtname.Text;
            s.age = int.Parse(txtage.Text);
            s.adress = txtadrs.Text;
            db.studint.Add(s);
            db.SaveChanges();
            MessageBox.Show("datasaved bay");
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_list std = new student_list();
            std.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtid.Text);
         studint s =  db.studint.FirstOrDefault(y => y.id == (n));
            txtadrs.Text = s.adress;
            txtage.Text = s.age.ToString();
            txtname.Text = s.name;
            

        }
    }
}
