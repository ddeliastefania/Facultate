using ObjectWCF;
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
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
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
            new MyPhotos().CreateUser(FirstName.Text, LastName.Text, Password.Text, Email.Text, Phone.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
            new MyPhotos().UpdateUser(Convert.ToInt32(userID.Text), FirstName.Text, LastName.Text, Password.Text, Email.Text, Phone.Text);
        }

        private void load_Click(object sender, EventArgs e)
        {
            new MyPhotos().GetUserById(Convert.ToInt32(userID.Text));
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new MyPhotos().DeleteUser(Convert.ToInt32(userID.Text));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            
            if (emailLog.Text == ""  || textBox2.Text == "")
            {
                MessageBox.Show("Invalid UserName and Password");
                return;
            }
            else
            {
                if(new MyPhotos().Login(emailLog.Text, textBox2.Text))
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Password or username not found");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
