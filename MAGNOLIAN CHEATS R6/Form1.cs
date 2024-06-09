namespace MAGNOLIAN_CHEATS_R6
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.Show();
        }
    }
}
