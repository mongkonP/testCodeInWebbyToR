using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Lifewithoutgenerics.htm
    public partial  class frmLifewithoutgenerics:Form
    {
        public frmLifewithoutgenerics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLifewithoutgenerics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLifewithoutgenerics";
            this.Text = "frmLifewithoutgenerics";
            this.Load += new System.EventHandler(this.frmLifewithoutgenerics_Load);
            this.ResumeLayout(false);

        }

        private void frmLifewithoutgenerics_Load(object sender, EventArgs e)
        {

        }
    }
}
