using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Obtainingareadonlycopyofalist.htm
    public partial  class frmObtainingareadonlycopyofalist:Form
    {
        public frmObtainingareadonlycopyofalist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObtainingareadonlycopyofalist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObtainingareadonlycopyofalist";
            this.Text = "frmObtainingareadonlycopyofalist";
            this.Load += new System.EventHandler(this.frmObtainingareadonlycopyofalist_Load);
            this.ResumeLayout(false);

        }

        private void frmObtainingareadonlycopyofalist_Load(object sender, EventArgs e)
        {

        }
    }
}
