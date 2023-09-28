using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2005__Bind_to_Property
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Nullpropertybinding.htm
    public partial  class frmNullpropertybinding:Form
    {
        public frmNullpropertybinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullpropertybinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullpropertybinding";
            this.Text = "frmNullpropertybinding";
            this.Load += new System.EventHandler(this.frmNullpropertybinding_Load);
            this.ResumeLayout(false);

        }

        private void frmNullpropertybinding_Load(object sender, EventArgs e)
        {

        }
    }
}
