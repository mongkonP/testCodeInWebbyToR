using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0020__delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/delegateisafunctionpointer.htm
    public partial  class frmdelegateisafunctionpointer:Form
    {
        public frmdelegateisafunctionpointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdelegateisafunctionpointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdelegateisafunctionpointer";
            this.Text = "frmdelegateisafunctionpointer";
            this.Load += new System.EventHandler(this.frmdelegateisafunctionpointer_Load);
            this.ResumeLayout(false);

        }

        private void frmdelegateisafunctionpointer_Load(object sender, EventArgs e)
        {

        }
    }
}
