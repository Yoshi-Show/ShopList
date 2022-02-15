using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oby4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name;
            int Price;
            int Quantity;
            bool gotDouble = false; 

            Name = textBox1.Text.Trim();

            bool PriceOK = int.TryParse(textBox2.Text.Trim(), out Price);
            bool QuantityOK = int.TryParse(textBox3.Text.Trim(), out Quantity);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().StartsWith(Name))
                {
                    gotDouble = true;
                }
            }

            if (PriceOK && QuantityOK && Name.Length > 0 && !gotDouble)
            {
                listBox1.Items.Add(Name + " " + Price.ToString() + "p." + Quantity.ToString() + "шт.");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
