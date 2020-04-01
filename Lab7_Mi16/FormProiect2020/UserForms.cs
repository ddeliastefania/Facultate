using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProiect2020
{
    public partial class UserForms : Form
    {
        public UserForms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.masterDataSet.Users);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ModelProiect2020.User user = ModelProiect2020.User.CreateUser(FirstName.Text, LastName.Text, Password.Text, Email.Text, Phone.Text);
            ModelProiect2020.Proiect2020Container context = new ModelProiect2020.Proiect2020Container();
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
