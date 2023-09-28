using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0040__Generic_List
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Usegenericlisttostoreyourownclass.htm
    public partial  class frmUsegenericlisttostoreyourownclass:Form
    {
        public frmUsegenericlisttostoreyourownclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsegenericlisttostoreyourownclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsegenericlisttostoreyourownclass";
            this.Text = "frmUsegenericlisttostoreyourownclass";
            this.Load += new System.EventHandler(this.frmUsegenericlisttostoreyourownclass_Load);
            this.ResumeLayout(false);

        }

        private void frmUsegenericlisttostoreyourownclass_Load(object sender, EventArgs e)
        {

        }
    }
}
