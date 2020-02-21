using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPlanner
{
    public partial class Form1 : Form
    {
        
        
        

        float completetion = 0;
        Dictionary<string, int> assignment = new Dictionary<string, int>(); //Assignment name

        

        public Form1()
        {
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);

            InitializeComponent();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void toolStripProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel3.Text = DateTime.Now.ToString("MM-dd-yyyy");
            toolStripLabel4.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        
    }
}
