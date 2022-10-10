using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0060__richTextBox1_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/SubstitutingValues.htm
    public partial  class frmSubstitutingValues:Form
    {
        public frmSubstitutingValues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSubstitutingValues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSubstitutingValues";
            this.Text = "frmSubstitutingValues";
            this.Load += new System.EventHandler(this.frmSubstitutingValues_Load);
            this.ResumeLayout(false);

        }

        private void frmSubstitutingValues_Load(object sender, EventArgs e)
        {

        }
    }
}
