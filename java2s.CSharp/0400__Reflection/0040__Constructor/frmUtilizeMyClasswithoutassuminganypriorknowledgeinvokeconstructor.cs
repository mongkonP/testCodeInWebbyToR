using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0040__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/UtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor.htm
    public partial  class frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor:Form
    {
        public frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor";
            this.Text = "frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor";
            this.Load += new System.EventHandler(this.frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmUtilizeMyClasswithoutassuminganypriorknowledgeinvokeconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
