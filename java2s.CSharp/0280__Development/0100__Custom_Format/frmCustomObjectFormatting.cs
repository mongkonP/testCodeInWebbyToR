using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CustomObjectFormatting.htm
    public partial  class frmCustomObjectFormatting:Form
    {
        public frmCustomObjectFormatting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomObjectFormatting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomObjectFormatting";
            this.Text = "frmCustomObjectFormatting";
            this.Load += new System.EventHandler(this.frmCustomObjectFormatting_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomObjectFormatting_Load(object sender, EventArgs e)
        {

        }
    }
}
