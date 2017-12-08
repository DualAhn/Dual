using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            Text = string.Format("v{0} ({1})", Assembly.GetExecutingAssembly().FullName.Split(',')[1].Trim().Split('=')[1]
             , System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToShortDateString());
        }
    }
}
