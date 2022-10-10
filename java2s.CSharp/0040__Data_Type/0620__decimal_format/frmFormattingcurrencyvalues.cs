using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0620__decimal_format
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Formattingcurrencyvalues.htm
    public partial  class frmFormattingcurrencyvalues:Form
    {
        public frmFormattingcurrencyvalues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormattingcurrencyvalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormattingcurrencyvalues";
            this.Text = "frmFormattingcurrencyvalues";
            this.Load += new System.EventHandler(this.frmFormattingcurrencyvalues_Load);
            this.ResumeLayout(false);

        }

        private void frmFormattingcurrencyvalues_Load(object sender, EventArgs e)
        {

        }
    }
}
