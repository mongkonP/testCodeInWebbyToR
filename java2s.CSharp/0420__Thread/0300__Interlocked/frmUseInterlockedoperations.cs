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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseInterlockedoperations.htm
    public partial  class frmUseInterlockedoperations:Form
    {
        public frmUseInterlockedoperations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseInterlockedoperations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseInterlockedoperations";
            this.Text = "frmUseInterlockedoperations";
            this.Load += new System.EventHandler(this.frmUseInterlockedoperations_Load);
            this.ResumeLayout(false);

        }

        private void frmUseInterlockedoperations_Load(object sender, EventArgs e)
        {

        }
    }
}
