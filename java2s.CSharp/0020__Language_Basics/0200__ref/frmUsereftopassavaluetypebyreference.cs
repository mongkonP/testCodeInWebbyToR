using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0200__ref
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Usereftopassavaluetypebyreference.htm
    public partial  class frmUsereftopassavaluetypebyreference:Form
    {
        public frmUsereftopassavaluetypebyreference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsereftopassavaluetypebyreference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsereftopassavaluetypebyreference";
            this.Text = "frmUsereftopassavaluetypebyreference";
            this.Load += new System.EventHandler(this.frmUsereftopassavaluetypebyreference_Load);
            this.ResumeLayout(false);

        }

        private void frmUsereftopassavaluetypebyreference_Load(object sender, EventArgs e)
        {

        }
    }
}
