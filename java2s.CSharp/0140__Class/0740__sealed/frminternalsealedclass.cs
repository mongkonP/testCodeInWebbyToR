using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0740__sealed
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/internalsealedclass.htm
    public partial  class frminternalsealedclass:Form
    {
        public frminternalsealedclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frminternalsealedclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frminternalsealedclass";
            this.Text = "frminternalsealedclass";
            this.Load += new System.EventHandler(this.frminternalsealedclass_Load);
            this.ResumeLayout(false);

        }

        private void frminternalsealedclass_Load(object sender, EventArgs e)
        {

        }
    }
}
