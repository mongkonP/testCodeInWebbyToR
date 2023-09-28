using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0420__ToDictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ConvertquerytoDictionary.htm
    public partial  class frmConvertquerytoDictionary:Form
    {
        public frmConvertquerytoDictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConvertquerytoDictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConvertquerytoDictionary";
            this.Text = "frmConvertquerytoDictionary";
            this.Load += new System.EventHandler(this.frmConvertquerytoDictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmConvertquerytoDictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
