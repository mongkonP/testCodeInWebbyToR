using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0680__enum
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Enumerations.htm
    public partial  class frmEnumerations:Form
    {
        public frmEnumerations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumerations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumerations";
            this.Text = "frmEnumerations";
            this.Load += new System.EventHandler(this.frmEnumerations_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumerations_Load(object sender, EventArgs e)
        {

        }
    }
}
