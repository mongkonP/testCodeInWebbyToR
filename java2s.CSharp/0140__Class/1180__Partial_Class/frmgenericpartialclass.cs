using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1180__Partial_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/genericpartialclass.htm
    public partial  class frmgenericpartialclass:Form
    {
        public frmgenericpartialclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmgenericpartialclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmgenericpartialclass";
            this.Text = "frmgenericpartialclass";
            this.Load += new System.EventHandler(this.frmgenericpartialclass_Load);
            this.ResumeLayout(false);

        }

        private void frmgenericpartialclass_Load(object sender, EventArgs e)
        {

        }
    }
}
