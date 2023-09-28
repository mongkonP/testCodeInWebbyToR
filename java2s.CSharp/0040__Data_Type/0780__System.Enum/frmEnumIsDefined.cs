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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/EnumIsDefined.htm
    public partial  class frmEnumIsDefined:Form
    {
        public frmEnumIsDefined()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumIsDefined
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumIsDefined";
            this.Text = "frmEnumIsDefined";
            this.Load += new System.EventHandler(this.frmEnumIsDefined_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumIsDefined_Load(object sender, EventArgs e)
        {

        }
    }
}
