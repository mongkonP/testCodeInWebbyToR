using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0040__Verbatim_literal_strings
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/VerbatimStrings.htm
    public partial  class frmVerbatimStrings:Form
    {
        public frmVerbatimStrings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVerbatimStrings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVerbatimStrings";
            this.Text = "frmVerbatimStrings";
            this.Load += new System.EventHandler(this.frmVerbatimStrings_Load);
            this.ResumeLayout(false);

        }

        private void frmVerbatimStrings_Load(object sender, EventArgs e)
        {

        }
    }
}
