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
	public partial class Management
	{
        void Update()
        {
            Form1.toolStripLabel3.Text = DateTime.Now.ToString("MM-dd-yyyy");
            Form1.toolStripLabel4.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
