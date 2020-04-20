//using ModelProiect2020;
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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            new ProjectClient().CreateData(datatype.Text, Convert.ToDateTime(creationDate.Text), eventname.Text, people.Text, path.Text, location.Text);
        }

        private void load_Click(object sender, EventArgs e)
        {
            var myData = new ProjectClient().GetAllData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new MyPhotos().DeleteData(Convert.ToInt32(dataID.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            new ProjectClient().UpdateData(Convert.ToInt32(dataID.Text), datatype.Text, Convert.ToDateTime(creationDate.Text), eventname.Text, people.Text, path.Text, location.Text); 
        }
    }
}
