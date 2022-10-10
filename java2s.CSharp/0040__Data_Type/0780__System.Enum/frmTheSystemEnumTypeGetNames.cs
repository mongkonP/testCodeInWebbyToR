using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0780__System.Enum
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/TheSystemEnumTypeGetNames.htm
    public partial  class frmTheSystemEnumTypeGetNames:Form
    {
        public frmTheSystemEnumTypeGetNames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheSystemEnumTypeGetNames
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheSystemEnumTypeGetNames";
            this.Text = "frmTheSystemEnumTypeGetNames";
            this.Load += new System.EventHandler(this.frmTheSystemEnumTypeGetNames_Load);
            this.ResumeLayout(false);

        }

        private void frmTheSystemEnumTypeGetNames_Load(object sender, EventArgs e)
        {

        }
    }
}
