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
    public partial class SpecialPropertiesForm : Form
    {
        public SpecialPropertiesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelProiect2020.SpecialProperty specialProperty = ModelProiect2020.SpecialProperty.CreateSpecialProperty(propertyName.Text, propertyDescription.Text);
            ModelProiect2020.Proiect2020Container context = new ModelProiect2020.Proiect2020Container();
            context.SpecialProperties.Add(specialProperty);
            context.SaveChanges();
        }
    }
}
