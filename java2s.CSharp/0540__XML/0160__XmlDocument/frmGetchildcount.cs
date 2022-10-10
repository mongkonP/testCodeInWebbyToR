using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0160__XmlDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Getchildcount.htm
    public partial  class frmGetchildcount:Form
    {
        public frmGetchildcount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetchildcount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetchildcount";
            this.Text = "frmGetchildcount";
            this.Load += new System.EventHandler(this.frmGetchildcount_Load);
            this.ResumeLayout(false);

        }

        private void frmGetchildcount_Load(object sender, EventArgs e)
        {

        }
    }
}
