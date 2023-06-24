using OpenCvSharp;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace PairingLogo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseImageFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = dialog.SelectedPath;
                    txtImageFolder.Text = selectedFolder;
                }
                else
                {
                    txtImageFolder.Text = string.Empty;
                }
            }
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select an image file";
                dialog.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = dialog.FileName;
                    txtLogo.Text = selectedFile;
                }
                else
                {
                    txtLogo.Text = string.Empty;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImageFolder.Text))
            {
                MessageBox.Show("You must select image folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtLogo.Text))
            {
                MessageBox.Show("You must select logo image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnProcess.Text = "Processing...";
            btnProcess.Enabled = false;
            IEnumerable<string> imageFilePaths = Directory.GetFiles(txtImageFolder.Text, "*.*", SearchOption.AllDirectories)
            .Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".jpeg"));

            string shortPathLogo = GetShortPath(txtLogo.Text);
            Mat logo = Cv2.ImRead(shortPathLogo);

            int logoWidth = Convert.ToInt32(logo.Width * nmrRatio.Value / 100);
            int logoHeight = Convert.ToInt32(logo.Height * nmrRatio.Value / 100);

            Cv2.Resize(logo, logo, new Size(logoWidth, logoHeight));

            foreach (string imageFiles in imageFilePaths)
            {
                string shortPath = GetShortPath(imageFiles);
                Mat image = Cv2.ImRead(shortPath);


                int rows = image.Rows;
                int cols = image.Cols;

                int logoLeft = cols - logoWidth;
                int logoTop = rows - logoHeight;

                Point logoTopLeft = new Point(logoLeft, logoTop);
                Rect logoRect = new Rect(logoTopLeft, new Size(logoWidth, logoHeight));

                try
                {
                    logo.CopyTo(image[logoRect]);
                }
                catch 
                {
                    continue;
                }

                Cv2.ImWrite(shortPath, image);
            }
            btnProcess.Enabled = true;
            btnProcess.Text = "Process Image";
            MessageBox.Show("Process Complete", "Noti");
            Process.Start("explorer.exe", txtImageFolder.Text);
        }

        private static string GetShortPath(string longPath)
        {
            StringBuilder shortPathBuffer = new StringBuilder(256);
            GetShortPathName(longPath, shortPathBuffer, shortPathBuffer.Capacity);
            return shortPathBuffer.ToString();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetShortPathName(string longPath, StringBuilder shortPathBuffer, int bufferLength);
    }
}