using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1160__Extension
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/conflictingextensionmethods.htm
    public partial  class frmconflictingextensionmethods:Form
    {
        public frmconflictingextensionmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmconflictingextensionmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmconflictingextensionmethods";
            this.Text = "frmconflictingextensionmethods";
            this.Load += new System.EventHandler(this.frmconflictingextensionmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmconflictingextensionmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
