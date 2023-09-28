using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0260__Equals
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Valuetypeequalityoverride.htm
    public partial  class frmValuetypeequalityoverride:Form
    {
        public frmValuetypeequalityoverride()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValuetypeequalityoverride
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValuetypeequalityoverride";
            this.Text = "frmValuetypeequalityoverride";
            this.Load += new System.EventHandler(this.frmValuetypeequalityoverride_Load);
            this.ResumeLayout(false);

        }

        private void frmValuetypeequalityoverride_Load(object sender, EventArgs e)
        {

        }
    }
}
