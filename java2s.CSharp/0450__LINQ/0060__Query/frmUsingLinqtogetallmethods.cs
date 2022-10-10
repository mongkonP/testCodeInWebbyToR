using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0060__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UsingLinqtogetallmethods.htm
    public partial  class frmUsingLinqtogetallmethods:Form
    {
        public frmUsingLinqtogetallmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingLinqtogetallmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingLinqtogetallmethods";
            this.Text = "frmUsingLinqtogetallmethods";
            this.Load += new System.EventHandler(this.frmUsingLinqtogetallmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingLinqtogetallmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
