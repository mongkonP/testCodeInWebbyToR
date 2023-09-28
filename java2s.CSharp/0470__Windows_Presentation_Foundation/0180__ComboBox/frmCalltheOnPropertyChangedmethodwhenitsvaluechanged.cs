using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0180__ComboBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CalltheOnPropertyChangedmethodwhenitsvaluechanged.htm
    public partial  class frmCalltheOnPropertyChangedmethodwhenitsvaluechanged:Form
    {
        public frmCalltheOnPropertyChangedmethodwhenitsvaluechanged()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalltheOnPropertyChangedmethodwhenitsvaluechanged
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCalltheOnPropertyChangedmethodwhenitsvaluechanged";
            this.Text = "frmCalltheOnPropertyChangedmethodwhenitsvaluechanged";
            this.Load += new System.EventHandler(this.frmCalltheOnPropertyChangedmethodwhenitsvaluechanged_Load);
            this.ResumeLayout(false);

        }

        private void frmCalltheOnPropertyChangedmethodwhenitsvaluechanged_Load(object sender, EventArgs e)
        {

        }
    }
}
