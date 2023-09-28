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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Valuetypesarepassedbyvalue.htm
    public partial  class frmValuetypesarepassedbyvalue:Form
    {
        public frmValuetypesarepassedbyvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValuetypesarepassedbyvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValuetypesarepassedbyvalue";
            this.Text = "frmValuetypesarepassedbyvalue";
            this.Load += new System.EventHandler(this.frmValuetypesarepassedbyvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmValuetypesarepassedbyvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
