

namespace Music_Player
{
    public partial class frm_player : Form
    {
        public frm_player()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "mp4 files|*.mp4|avi files|*.avi|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName.ToString();
                lstPlay.Items.Add(fname);
                wmp1.URL = fname;
                wmp1.Ctlcontrols.play();

            }

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                var fnames = Directory.GetFiles(path);

                foreach (string fname in fnames)
                {
                    lstPlay.Items.Add(fname);
                }
            }
        }

        private void lstPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fname = lstPlay.SelectedItems.ToString();
            wmp1.URL = fname;
            wmp1.Ctlcontrols.play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
