using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Copyaclass.htm
    public partial  class frmCopyaclass:Form
    {
        public frmCopyaclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyaclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyaclass";
            this.Text = "frmCopyaclass";
            this.Load += new System.EventHandler(this.frmCopyaclass_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyaclass_Load(object sender, EventArgs e)
        {

        }
    }
}
