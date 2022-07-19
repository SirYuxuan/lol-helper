using LOLHelper.Common;
using LOLHelper.Const;

namespace LOLHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

           Global.debugForm = new Debug.Debug(this);

            if (Global.DEBUG) 
            {
                // ´ò¿ªDEBUG´°¿Ú
                Global.debugForm.Show();
            }
            Init.Load();
        }
    }
}