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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Usereftopassanintvaluetypebyreference.htm
    public partial  class frmUsereftopassanintvaluetypebyreference:Form
    {
        public frmUsereftopassanintvaluetypebyreference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsereftopassanintvaluetypebyreference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsereftopassanintvaluetypebyreference";
            this.Text = "frmUsereftopassanintvaluetypebyreference";
            this.Load += new System.EventHandler(this.frmUsereftopassanintvaluetypebyreference_Load);
            this.ResumeLayout(false);

        }

        private void frmUsereftopassanintvaluetypebyreference_Load(object sender, EventArgs e)
        {

        }
    }
}
