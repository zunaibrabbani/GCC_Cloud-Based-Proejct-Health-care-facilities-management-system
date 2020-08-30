using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace GCC_Project
{
    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8SMEzkls2zkF3AQWGLhX8DlcPI3E32q6mpv9XlIt",
            BasePath = "https://gcc-project2020.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Cloud Firebase Connection is Established");
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Width += 16;

                if (pictureBox1.Width >= 1300)
                {
                    timer1.Stop();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();

                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
