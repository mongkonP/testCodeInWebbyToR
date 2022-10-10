using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1300__Single
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Singlewithcondition.htm
    public partial  class frmSinglewithcondition:Form
    {
        public frmSinglewithcondition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSinglewithcondition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSinglewithcondition";
            this.Text = "frmSinglewithcondition";
            this.Load += new System.EventHandler(this.frmSinglewithcondition_Load);
            this.ResumeLayout(false);

        }

        private void frmSinglewithcondition_Load(object sender, EventArgs e)
        {

        }
    }
}
