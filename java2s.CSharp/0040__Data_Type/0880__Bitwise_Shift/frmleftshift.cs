using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0880__Bitwise_Shift
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/leftshift.htm
    public partial  class frmleftshift:Form
    {
        public frmleftshift()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmleftshift
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmleftshift";
            this.Text = "frmleftshift";
            this.Load += new System.EventHandler(this.frmleftshift_Load);
            this.ResumeLayout(false);

        }

        private void frmleftshift_Load(object sender, EventArgs e)
        {

        }
    }
}
