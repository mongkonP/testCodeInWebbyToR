using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Constuctorhidden.htm
    public partial  class frmConstuctorhidden:Form
    {
        public frmConstuctorhidden()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConstuctorhidden
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConstuctorhidden";
            this.Text = "frmConstuctorhidden";
            this.Load += new System.EventHandler(this.frmConstuctorhidden_Load);
            this.ResumeLayout(false);

        }

        private void frmConstuctorhidden_Load(object sender, EventArgs e)
        {

        }
    }
}
