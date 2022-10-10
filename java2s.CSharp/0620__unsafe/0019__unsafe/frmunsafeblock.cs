using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/unsafeblock.htm
    public partial  class frmunsafeblock:Form
    {
        public frmunsafeblock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmunsafeblock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmunsafeblock";
            this.Text = "frmunsafeblock";
            this.Load += new System.EventHandler(this.frmunsafeblock_Load);
            this.ResumeLayout(false);

        }

        private void frmunsafeblock_Load(object sender, EventArgs e)
        {

        }
    }
}
