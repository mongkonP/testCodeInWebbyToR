using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0220__Anonymous
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AnonymousTypeInArray.htm
    public partial  class frmAnonymousTypeInArray:Form
    {
        public frmAnonymousTypeInArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousTypeInArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousTypeInArray";
            this.Text = "frmAnonymousTypeInArray";
            this.Load += new System.EventHandler(this.frmAnonymousTypeInArray_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousTypeInArray_Load(object sender, EventArgs e)
        {

        }
    }
}
