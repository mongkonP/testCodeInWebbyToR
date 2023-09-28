using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0140__Delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GeteventfromType.htm
    public partial  class frmGeteventfromType:Form
    {
        public frmGeteventfromType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeteventfromType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeteventfromType";
            this.Text = "frmGeteventfromType";
            this.Load += new System.EventHandler(this.frmGeteventfromType_Load);
            this.ResumeLayout(false);

        }

        private void frmGeteventfromType_Load(object sender, EventArgs e)
        {

        }
    }
}
