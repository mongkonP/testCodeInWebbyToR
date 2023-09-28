using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0240__Array_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Copyingelementsbetweenarrays.htm
    public partial  class frmCopyingelementsbetweenarrays:Form
    {
        public frmCopyingelementsbetweenarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyingelementsbetweenarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyingelementsbetweenarrays";
            this.Text = "frmCopyingelementsbetweenarrays";
            this.Load += new System.EventHandler(this.frmCopyingelementsbetweenarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyingelementsbetweenarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
