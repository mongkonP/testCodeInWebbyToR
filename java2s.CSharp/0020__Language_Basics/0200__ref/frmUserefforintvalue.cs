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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Userefforintvalue.htm
    public partial  class frmUserefforintvalue:Form
    {
        public frmUserefforintvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserefforintvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserefforintvalue";
            this.Text = "frmUserefforintvalue";
            this.Load += new System.EventHandler(this.frmUserefforintvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmUserefforintvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
