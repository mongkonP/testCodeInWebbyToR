using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0560__decimal
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/decimalTypes.htm
    public partial  class frmdecimalTypes:Form
    {
        public frmdecimalTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdecimalTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdecimalTypes";
            this.Text = "frmdecimalTypes";
            this.Load += new System.EventHandler(this.frmdecimalTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmdecimalTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
