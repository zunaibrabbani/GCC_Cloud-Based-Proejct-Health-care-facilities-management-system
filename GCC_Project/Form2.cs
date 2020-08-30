using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCC_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '*';

            this.textBox1.CharacterCasing = CharacterCasing.Lower;
            this.textBox2.CharacterCasing = CharacterCasing.Lower;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text == "admin")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Input! Hint: Username & Password 'admin' ");
            }
        }
    }
}
