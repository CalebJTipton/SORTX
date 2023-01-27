namespace SORTX
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        String directoryPath;
        private void browseDirectory_btn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryPath = folderBrowserDialog1.SelectedPath; //updates the directoryPath variable with dialog selection
                directoryPath_txt.Text = directoryPath; //updates the directoryPath textbok with the new dialog selection
            }
        }
    }
}