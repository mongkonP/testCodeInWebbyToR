using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0040__Class_Instance
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/publicmembermethod.htm
    public partial  class frmpublicmembermethod:Form
    {
        public frmpublicmembermethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmpublicmembermethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmpublicmembermethod";
            this.Text = "frmpublicmembermethod";
            this.Load += new System.EventHandler(this.frmpublicmembermethod_Load);
            this.ResumeLayout(false);

        }

        private void frmpublicmembermethod_Load(object sender, EventArgs e)
        {

        }
    }
}
