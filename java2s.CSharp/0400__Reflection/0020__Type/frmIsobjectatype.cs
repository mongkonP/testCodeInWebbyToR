using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Isobjectatype.htm
    public partial  class frmIsobjectatype:Form
    {
        public frmIsobjectatype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsobjectatype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsobjectatype";
            this.Text = "frmIsobjectatype";
            this.Load += new System.EventHandler(this.frmIsobjectatype_Load);
            this.ResumeLayout(false);

        }

        private void frmIsobjectatype_Load(object sender, EventArgs e)
        {

        }
    }
}
