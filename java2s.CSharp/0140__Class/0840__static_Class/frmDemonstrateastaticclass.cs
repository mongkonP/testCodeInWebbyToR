using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0840__static_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Demonstrateastaticclass.htm
    public partial  class frmDemonstrateastaticclass:Form
    {
        public frmDemonstrateastaticclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateastaticclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateastaticclass";
            this.Text = "frmDemonstrateastaticclass";
            this.Load += new System.EventHandler(this.frmDemonstrateastaticclass_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateastaticclass_Load(object sender, EventArgs e)
        {

        }
    }
}
