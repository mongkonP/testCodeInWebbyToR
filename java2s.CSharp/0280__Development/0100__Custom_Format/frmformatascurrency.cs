using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/formatascurrency.htm
    public partial  class frmformatascurrency:Form
    {
        public frmformatascurrency()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmformatascurrency
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmformatascurrency";
            this.Text = "frmformatascurrency";
            this.Load += new System.EventHandler(this.frmformatascurrency_Load);
            this.ResumeLayout(false);

        }

        private void frmformatascurrency_Load(object sender, EventArgs e)
        {

        }
    }
}
