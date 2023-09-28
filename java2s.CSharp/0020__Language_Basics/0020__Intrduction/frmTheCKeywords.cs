using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0020__Intrduction
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TheCKeywords.htm
    public partial  class frmTheCKeywords:Form
    {
        public frmTheCKeywords()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheCKeywords
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheCKeywords";
            this.Text = "frmTheCKeywords";
            this.Load += new System.EventHandler(this.frmTheCKeywords_Load);
            this.ResumeLayout(false);

        }

        private void frmTheCKeywords_Load(object sender, EventArgs e)
        {

        }
    }
}
