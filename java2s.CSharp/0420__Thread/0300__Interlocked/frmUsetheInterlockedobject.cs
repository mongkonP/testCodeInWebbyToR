using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0300__Interlocked
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UsetheInterlockedobject.htm
    public partial  class frmUsetheInterlockedobject:Form
    {
        public frmUsetheInterlockedobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheInterlockedobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheInterlockedobject";
            this.Text = "frmUsetheInterlockedobject";
            this.Load += new System.EventHandler(this.frmUsetheInterlockedobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheInterlockedobject_Load(object sender, EventArgs e)
        {

        }
    }
}
