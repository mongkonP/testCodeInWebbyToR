using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0500__StackTrace
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Stackframes.htm
    public partial  class frmStackframes:Form
    {
        public frmStackframes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStackframes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStackframes";
            this.Text = "frmStackframes";
            this.Load += new System.EventHandler(this.frmStackframes_Load);
            this.ResumeLayout(false);

        }

        private void frmStackframes_Load(object sender, EventArgs e)
        {

        }
    }
}
