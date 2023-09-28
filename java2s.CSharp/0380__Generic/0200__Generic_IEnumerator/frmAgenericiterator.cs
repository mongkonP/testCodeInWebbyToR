using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0200__Generic_IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Agenericiterator.htm
    public partial  class frmAgenericiterator:Form
    {
        public frmAgenericiterator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAgenericiterator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAgenericiterator";
            this.Text = "frmAgenericiterator";
            this.Load += new System.EventHandler(this.frmAgenericiterator_Load);
            this.ResumeLayout(false);

        }

        private void frmAgenericiterator_Load(object sender, EventArgs e)
        {

        }
    }
}
