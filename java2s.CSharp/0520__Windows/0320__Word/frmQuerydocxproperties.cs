using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0320__Word
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Querydocxproperties.htm
    public partial  class frmQuerydocxproperties:Form
    {
        public frmQuerydocxproperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQuerydocxproperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQuerydocxproperties";
            this.Text = "frmQuerydocxproperties";
            this.Load += new System.EventHandler(this.frmQuerydocxproperties_Load);
            this.ResumeLayout(false);

        }

        private void frmQuerydocxproperties_Load(object sender, EventArgs e)
        {

        }
    }
}
