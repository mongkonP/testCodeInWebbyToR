using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0260__Parameter_Value
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Passingreftypesbyvalue.htm
    public partial  class frmPassingreftypesbyvalue:Form
    {
        public frmPassingreftypesbyvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassingreftypesbyvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassingreftypesbyvalue";
            this.Text = "frmPassingreftypesbyvalue";
            this.Load += new System.EventHandler(this.frmPassingreftypesbyvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmPassingreftypesbyvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
