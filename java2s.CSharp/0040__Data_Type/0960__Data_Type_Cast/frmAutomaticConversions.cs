using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0960__Data_Type_Cast
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/AutomaticConversions.htm
    public partial  class frmAutomaticConversions:Form
    {
        public frmAutomaticConversions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAutomaticConversions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAutomaticConversions";
            this.Text = "frmAutomaticConversions";
            this.Load += new System.EventHandler(this.frmAutomaticConversions_Load);
            this.ResumeLayout(false);

        }

        private void frmAutomaticConversions_Load(object sender, EventArgs e)
        {

        }
    }
}
