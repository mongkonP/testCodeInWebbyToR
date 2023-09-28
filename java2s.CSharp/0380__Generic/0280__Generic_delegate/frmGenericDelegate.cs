using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0280__Generic_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericDelegate.htm
    public partial  class frmGenericDelegate:Form
    {
        public frmGenericDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericDelegate";
            this.Text = "frmGenericDelegate";
            this.Load += new System.EventHandler(this.frmGenericDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
