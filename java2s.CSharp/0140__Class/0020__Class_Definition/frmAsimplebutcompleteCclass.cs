using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/AsimplebutcompleteCclass.htm
    public partial  class frmAsimplebutcompleteCclass:Form
    {
        public frmAsimplebutcompleteCclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimplebutcompleteCclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimplebutcompleteCclass";
            this.Text = "frmAsimplebutcompleteCclass";
            this.Load += new System.EventHandler(this.frmAsimplebutcompleteCclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimplebutcompleteCclass_Load(object sender, EventArgs e)
        {

        }
    }
}
