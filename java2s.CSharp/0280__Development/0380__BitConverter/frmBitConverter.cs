using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0380__BitConverter
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/BitConverter.htm
    public partial  class frmBitConverter:Form
    {
        public frmBitConverter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitConverter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitConverter";
            this.Text = "frmBitConverter";
            this.Load += new System.EventHandler(this.frmBitConverter_Load);
            this.ResumeLayout(false);

        }

        private void frmBitConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
