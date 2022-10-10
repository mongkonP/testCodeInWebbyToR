using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0940__unchecked
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/uncheckedmarker.htm
    public partial  class frmuncheckedmarker:Form
    {
        public frmuncheckedmarker()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmuncheckedmarker
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmuncheckedmarker";
            this.Text = "frmuncheckedmarker";
            this.Load += new System.EventHandler(this.frmuncheckedmarker_Load);
            this.ResumeLayout(false);

        }

        private void frmuncheckedmarker_Load(object sender, EventArgs e)
        {

        }
    }
}
