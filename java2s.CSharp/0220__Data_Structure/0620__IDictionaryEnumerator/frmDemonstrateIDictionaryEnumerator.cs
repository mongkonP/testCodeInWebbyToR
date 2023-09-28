using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0620__IDictionaryEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DemonstrateIDictionaryEnumerator.htm
    public partial  class frmDemonstrateIDictionaryEnumerator:Form
    {
        public frmDemonstrateIDictionaryEnumerator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateIDictionaryEnumerator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateIDictionaryEnumerator";
            this.Text = "frmDemonstrateIDictionaryEnumerator";
            this.Load += new System.EventHandler(this.frmDemonstrateIDictionaryEnumerator_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateIDictionaryEnumerator_Load(object sender, EventArgs e)
        {

        }
    }
}
