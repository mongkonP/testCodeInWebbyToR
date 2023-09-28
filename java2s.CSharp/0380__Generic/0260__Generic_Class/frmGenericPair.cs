using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0260__Generic_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericPair.htm
    public partial  class frmGenericPair:Form
    {
        public frmGenericPair()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericPair
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericPair";
            this.Text = "frmGenericPair";
            this.Load += new System.EventHandler(this.frmGenericPair_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericPair_Load(object sender, EventArgs e)
        {

        }
    }
}
