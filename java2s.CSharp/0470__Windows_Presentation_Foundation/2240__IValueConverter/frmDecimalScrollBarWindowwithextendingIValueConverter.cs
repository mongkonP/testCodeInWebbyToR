using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2240__IValueConverter
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DecimalScrollBarWindowwithextendingIValueConverter.htm
    public partial  class frmDecimalScrollBarWindowwithextendingIValueConverter:Form
    {
        public frmDecimalScrollBarWindowwithextendingIValueConverter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDecimalScrollBarWindowwithextendingIValueConverter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDecimalScrollBarWindowwithextendingIValueConverter";
            this.Text = "frmDecimalScrollBarWindowwithextendingIValueConverter";
            this.Load += new System.EventHandler(this.frmDecimalScrollBarWindowwithextendingIValueConverter_Load);
            this.ResumeLayout(false);

        }

        private void frmDecimalScrollBarWindowwithextendingIValueConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
