namespace DismImagingGUI;

internal partial class Form1 : Form
{
    internal string OutputPath;
    
    internal string SourceDirectory;
    
    internal Form1()
    {
        OutputPath = imageFile_TextBox.Text;
        SourceDirectory = sourceDir_TextBox.Text;
        InitializeComponent();
    }
    
    internal Form1(string outputPath, string sourceDirectory)
    {
        OutputPath = outputPath;
        imageFile_TextBox.Text = outputPath;

        SourceDirectory = sourceDirectory;
        sourceDir_TextBox.Text = sourceDirectory;
        InitializeComponent();
    }
}