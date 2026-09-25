using Microsoft.Wim;

namespace DismImagingGUI;

internal partial class MainWindow : Form
{
    internal string WimPath;

    internal string CapturePath;

    internal WimCompressionType CompressionType = WimCompressionType.Xpress;

    internal bool DirAcl = false;

    internal bool FileAcl = false;

    internal bool NoRpFix = false;

    internal bool Verify = false;

    internal MainWindow()
    {
        Initialize();
    }

    internal MainWindow(string wimPath, string capturePath, uint compressionType, bool? dirAcl, bool? fileAcl, bool? noRpFix, bool? verify)
    {
        Initialize();
        WimPath_TextBox.Text = wimPath;
        CapturePath_TextBox.Text = capturePath;
        CompressLvl_ComboBox.SelectedIndex = (int)compressionType;
        //CompressionType = (WimCompressionType)compressionType;
        if (dirAcl != null)
            DirectoryAcl_CheckBox.Checked = (bool)dirAcl;
        if (fileAcl != null)
            FileAcl_CheckBox.Checked = (bool)fileAcl;
        if (noRpFix != null)
            NoRpFix_CheckBox.Checked = (bool)noRpFix;
        if (verify != null)
            Verify_CheckBox.Checked = (bool)verify;
    }

    private void Initialize()
    {
        InitializeComponent();
        Append_Button.Enabled = false;
        OpenFileDialog.FileOk += (s, e) => WimPath_TextBox.Text = Path.Combine(OpenFileDialog.FileName);
        CompressLvl_ComboBox.Text = CompressLvl_ComboBox.Items[1] as string;
    }

    private void CreateButton_Click(object sender, EventArgs e)
        => DismApiFunctions.CreateWimImage(CapturePath, WimPath, DirAcl, FileAcl, NoRpFix, Verify, CompressionType, ImagingMode.Create);

    private void AppendImageButton_Click(object sender, EventArgs e)
        => DismApiFunctions.CreateWimImage(CapturePath, WimPath, DirAcl, FileAcl, NoRpFix, Verify, CompressionType, ImagingMode.Append);

    private void WimPath_TextBox_TextChanged(object sender, EventArgs e)
        => WimPath = Path.Combine(WimPath_TextBox.Text);

    private void CapturePath_TextBox_TextChanged(object sender, EventArgs e)
        => CapturePath = Path.Combine(CapturePath_TextBox.Text);

    private void DirectoryAcl_CheckBox_CheckedChanged(object sender, EventArgs e)
        => DirAcl = DirectoryAcl_CheckBox.Checked;

    private void FileAcl_CheckBox_CheckedChanged(object sender, EventArgs e)
        => FileAcl = FileAcl_CheckBox.Checked;

    private void NoRpFix_CheckBox_CheckedChanged(object sender, EventArgs e)
        => NoRpFix = NoRpFix_CheckBox.Checked;

    private void Verify_CheckBox_CheckedChanged(object sender, EventArgs e)
        => Verify = Verify_CheckBox.Checked;

    private void CompressLvl_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        => CompressionType = CompressLvl_ComboBox.SelectedIndex switch {
            0 => WimCompressionType.None,
            1 => WimCompressionType.Xpress,
            2 => WimCompressionType.Lzx,
            3 => WimCompressionType.Lzms,
            _ => throw new IndexOutOfRangeException("Combo Box selection out of range")
        };


    private void CancelButton_Click(object sender, EventArgs e)
        => this.Close();

    private void ImageFileBrowse_Button_Click(object sender, EventArgs e)
        => WimPath_TextBox.Text = OpenFileDialog.ShowDialog() == DialogResult.OK ? OpenFileDialog.FileName : WimPath_TextBox.Text;

    private void SourceDirBrowse_Button_Click(object sender, EventArgs e)
        => CapturePath_TextBox.Text = PathToImageDialog.ShowDialog() == DialogResult.OK ? PathToImageDialog.SelectedPath : CapturePath_TextBox.Text;
}