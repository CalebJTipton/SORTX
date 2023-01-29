namespace SORTX
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static String sourceDirectoryPath ="";
        static String outputDirectoryPath ="";

        private void sort()
        {

            consoleOutput_rtxt.Text = "Listing files by filetype in directory: " + sourceDirectoryPath; //clears previous console log

            var files = new DirectoryInfo(sourceDirectoryPath).GetFiles();
            var sortedFiles =
                from file in files
                orderby file.Extension
                select file;

            foreach (var file in sortedFiles)
            {
                consoleOutput_rtxt.Text = consoleOutput_rtxt.Text + "\n" + file.Name;
            }
        }
        private void browseDirectory_btn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceDirectoryPath = folderBrowserDialog1.SelectedPath; //updates the sourceDirectoryPath variable with dialog selection
                sourceDirectoryPath_txt.Text = sourceDirectoryPath; //updates the sourceDirectoryPath textbok with the new dialog selection
            }
        }

        private void sortDirectory_lbl_Click(object sender, EventArgs e)
        {

        }

        private void outputDirectoryBrowse_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryPath = folderBrowserDialog1.SelectedPath; //updates the sourceDirectoryPath variable with dialog selection
                outputDirectoryPath_txt.Text = outputDirectoryPath; //updates the sourceDirectoryPath textbok with the new dialog selection
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            sort();
        }
    }
}