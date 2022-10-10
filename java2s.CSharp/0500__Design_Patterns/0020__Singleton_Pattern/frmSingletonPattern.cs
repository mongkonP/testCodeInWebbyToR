using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0020__Singleton_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/SingletonPattern.htm
    public partial  class frmSingletonPattern:Form
    {
       
        public frmSingletonPattern()
        {
            InitializeComponent();
            
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSingletonPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSingletonPattern";
            this.Text = "frmSingletonPattern";
            this.Load += new System.EventHandler(this.frmSingletonPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmSingletonPattern_Load(object sender, EventArgs e)
        {
            SingletonClass s = SingletonClass.Instance;
            s.SomeMethod1();

            SingletonClass.Instance.SomeMethod2();
        }

      private  class SingletonClass
        {
            private static SingletonClass instance;

            static SingletonClass()
            {
                instance = new SingletonClass();
            }

            private SingletonClass() { }

            public static SingletonClass Instance
            {
                get { return instance; }
            }

            public void SomeMethod1() { }
            public void SomeMethod2() { }
        }

    }
}
