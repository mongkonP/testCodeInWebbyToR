using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0260__DomainUpDown
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextAlignandUpDownAlign.htm
    public partial  class frmTextAlignandUpDownAlign:Form
    {
        public frmTextAlignandUpDownAlign()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextAlignandUpDownAlign
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextAlignandUpDownAlign";
            this.Text = "frmTextAlignandUpDownAlign";
            this.Load += new System.EventHandler(this.frmTextAlignandUpDownAlign_Load);
            this.ResumeLayout(false);

        }

        private void frmTextAlignandUpDownAlign_Load(object sender, EventArgs e)
        {

        }
    }
}
