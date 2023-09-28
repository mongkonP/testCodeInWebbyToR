using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1580__DataBinding_Label
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BindClientSizetoLabel.htm
    public partial  class frmBindClientSizetoLabel:Form
    {
        public frmBindClientSizetoLabel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindClientSizetoLabel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindClientSizetoLabel";
            this.Text = "frmBindClientSizetoLabel";
            this.Load += new System.EventHandler(this.frmBindClientSizetoLabel_Load);
            this.ResumeLayout(false);

        }

        private void frmBindClientSizetoLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
