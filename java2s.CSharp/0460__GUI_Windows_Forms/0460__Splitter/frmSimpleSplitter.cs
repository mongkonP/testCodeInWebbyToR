using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0460__Splitter
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpleSplitter.htm
    public partial  class frmSimpleSplitter:Form
    {
        public frmSimpleSplitter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleSplitter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleSplitter";
            this.Text = "frmSimpleSplitter";
            this.Load += new System.EventHandler(this.frmSimpleSplitter_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleSplitter_Load(object sender, EventArgs e)
        {

        }
    }
}
