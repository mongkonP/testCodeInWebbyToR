using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0240__Parameter_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Objectsarepassedbyreference.htm
    public partial  class frmObjectsarepassedbyreference:Form
    {
        public frmObjectsarepassedbyreference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObjectsarepassedbyreference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObjectsarepassedbyreference";
            this.Text = "frmObjectsarepassedbyreference";
            this.Load += new System.EventHandler(this.frmObjectsarepassedbyreference_Load);
            this.ResumeLayout(false);

        }

        private void frmObjectsarepassedbyreference_Load(object sender, EventArgs e)
        {

        }
    }
}
