using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0980__DictionaryBase
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/extendsDictionaryBase.htm
    public partial  class frmextendsDictionaryBase:Form
    {
        public frmextendsDictionaryBase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsDictionaryBase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsDictionaryBase";
            this.Text = "frmextendsDictionaryBase";
            this.Load += new System.EventHandler(this.frmextendsDictionaryBase_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsDictionaryBase_Load(object sender, EventArgs e)
        {

        }
    }
}
