using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0880__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Asimpleexampleofaniterator.htm
    public partial  class frmAsimpleexampleofaniterator:Form
    {
        public frmAsimpleexampleofaniterator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpleexampleofaniterator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpleexampleofaniterator";
            this.Text = "frmAsimpleexampleofaniterator";
            this.Load += new System.EventHandler(this.frmAsimpleexampleofaniterator_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpleexampleofaniterator_Load(object sender, EventArgs e)
        {

        }
    }
}
