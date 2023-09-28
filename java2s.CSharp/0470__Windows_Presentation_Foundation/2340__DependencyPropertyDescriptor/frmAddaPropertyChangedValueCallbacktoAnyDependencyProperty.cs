using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2340__DependencyPropertyDescriptor
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddaPropertyChangedValueCallbacktoAnyDependencyProperty.htm
    public partial  class frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty:Form
    {
        public frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty";
            this.Text = "frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty";
            this.Load += new System.EventHandler(this.frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaPropertyChangedValueCallbacktoAnyDependencyProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
