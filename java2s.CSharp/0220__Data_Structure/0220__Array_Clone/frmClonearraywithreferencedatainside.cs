using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0220__Array_Clone
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Clonearraywithreferencedatainside.htm
    public partial  class frmClonearraywithreferencedatainside:Form
    {
        public frmClonearraywithreferencedatainside()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClonearraywithreferencedatainside
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClonearraywithreferencedatainside";
            this.Text = "frmClonearraywithreferencedatainside";
            this.Load += new System.EventHandler(this.frmClonearraywithreferencedatainside_Load);
            this.ResumeLayout(false);

        }

        private void frmClonearraywithreferencedatainside_Load(object sender, EventArgs e)
        {

        }
    }
}
