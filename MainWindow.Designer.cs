namespace DismImagingGUI;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        WimPath_TextBox = new TextBox();
        ImageFile_Label = new Label();
        DirectoryAcl_CheckBox = new CheckBox();
        Verify_CheckBox = new CheckBox();
        NoRpFix_CheckBox = new CheckBox();
        FileAcl_CheckBox = new CheckBox();
        CapturePath_TextBox = new TextBox();
        SourceDir_Label = new Label();
        Create_Button = new Button();
        Append_Button = new Button();
        Cancel_Button = new Button();
        SourceDirBrowse_Button = new Button();
        ImageFileBrowse_Button = new Button();
        CompressLvl_Label = new Label();
        CompressLvl_ComboBox = new ComboBox();
        OpenFileDialog = new OpenFileDialog();
        PathToImageDialog = new FolderBrowserDialog();
        SuspendLayout();
        // 
        // WimLocation_TextBox
        // 
        WimPath_TextBox.Location = new Point(103, 35);
        WimPath_TextBox.Name = "WimLocation_TextBox";
        WimPath_TextBox.Size = new Size(264, 23);
        WimPath_TextBox.TabIndex = 0;
        WimPath_TextBox.TextChanged += WimPath_TextBox_TextChanged;
        // 
        // ImageFile_Label
        // 
        ImageFile_Label.Location = new Point(12, 38);
        ImageFile_Label.Name = "ImageFile_Label";
        ImageFile_Label.Size = new Size(85, 20);
        ImageFile_Label.TabIndex = 1;
        ImageFile_Label.Text = "WIM location:";
        // 
        // DirectoryAcl_CheckBox
        // 
        DirectoryAcl_CheckBox.Location = new Point(12, 93);
        DirectoryAcl_CheckBox.Name = "DirectoryAcl_CheckBox";
        DirectoryAcl_CheckBox.Size = new Size(153, 24);
        DirectoryAcl_CheckBox.TabIndex = 14;
        DirectoryAcl_CheckBox.Text = "Disable Directory ACL";
        DirectoryAcl_CheckBox.UseVisualStyleBackColor = true;
        DirectoryAcl_CheckBox.CheckedChanged += DirectoryAcl_CheckBox_CheckedChanged;
        // 
        // Verify_CheckBox
        // 
        Verify_CheckBox.Location = new Point(12, 183);
        Verify_CheckBox.Name = "Verify_CheckBox";
        Verify_CheckBox.Size = new Size(118, 24);
        Verify_CheckBox.TabIndex = 15;
        Verify_CheckBox.Text = "Verify image files";
        Verify_CheckBox.UseVisualStyleBackColor = true;
        Verify_CheckBox.CheckedChanged += Verify_CheckBox_CheckedChanged;
        // 
        // NoRpFix_CheckBox
        // 
        NoRpFix_CheckBox.Location = new Point(12, 153);
        NoRpFix_CheckBox.Name = "NoRpFix_CheckBox";
        NoRpFix_CheckBox.Size = new Size(236, 24);
        NoRpFix_CheckBox.TabIndex = 16;
        NoRpFix_CheckBox.Text = "Disable fixing of junctions and symlinks";
        NoRpFix_CheckBox.UseVisualStyleBackColor = true;
        NoRpFix_CheckBox.CheckedChanged += NoRpFix_CheckBox_CheckedChanged;
        // 
        // FileAcl_CheckBox
        // 
        FileAcl_CheckBox.Location = new Point(12, 123);
        FileAcl_CheckBox.Name = "FileAcl_CheckBox";
        FileAcl_CheckBox.Size = new Size(168, 24);
        FileAcl_CheckBox.TabIndex = 17;
        FileAcl_CheckBox.Text = "Disable File ACL";
        FileAcl_CheckBox.UseVisualStyleBackColor = true;
        FileAcl_CheckBox.CheckedChanged += FileAcl_CheckBox_CheckedChanged;
        // 
        // CapturePath_TextBox
        // 
        CapturePath_TextBox.Location = new Point(103, 6);
        CapturePath_TextBox.Name = "CapturePath_TextBox";
        CapturePath_TextBox.Size = new Size(264, 23);
        CapturePath_TextBox.TabIndex = 18;
        CapturePath_TextBox.TextChanged += CapturePath_TextBox_TextChanged;
        // 
        // SourceDir_Label
        // 
        SourceDir_Label.Location = new Point(12, 9);
        SourceDir_Label.Name = "SourceDir_Label";
        SourceDir_Label.Size = new Size(85, 20);
        SourceDir_Label.TabIndex = 19;
        SourceDir_Label.Text = "Capture path:";
        // 
        // Create_Button
        // 
        Create_Button.Location = new Point(299, 302);
        Create_Button.Name = "Create_Button";
        Create_Button.Size = new Size(96, 24);
        Create_Button.TabIndex = 20;
        Create_Button.Text = "Create Image";
        Create_Button.UseVisualStyleBackColor = true;
        Create_Button.Click += CreateButton_Click;
        // 
        // Append_Button
        // 
        Append_Button.Location = new Point(196, 302);
        Append_Button.Name = "Append_Button";
        Append_Button.Size = new Size(96, 24);
        Append_Button.TabIndex = 21;
        Append_Button.Text = "Append Image";
        Append_Button.UseVisualStyleBackColor = true;
        Append_Button.Click += AppendImageButton_Click;
        // 
        // Cancel_Button
        // 
        Cancel_Button.Location = new Point(94, 302);
        Cancel_Button.Name = "Cancel_Button";
        Cancel_Button.Size = new Size(96, 24);
        Cancel_Button.TabIndex = 22;
        Cancel_Button.Text = "Cancel";
        Cancel_Button.UseVisualStyleBackColor = true;
        Cancel_Button.Click += CancelButton_Click;
        // 
        // SourceDirBrowse_Button
        // 
        SourceDirBrowse_Button.Location = new Point(373, 6);
        SourceDirBrowse_Button.Name = "SourceDirBrowse_Button";
        SourceDirBrowse_Button.Size = new Size(22, 20);
        SourceDirBrowse_Button.TabIndex = 23;
        SourceDirBrowse_Button.Text = "…";
        SourceDirBrowse_Button.UseVisualStyleBackColor = true;
        SourceDirBrowse_Button.Click += SourceDirBrowse_Button_Click;
        // 
        // ImageFileBrowse_Button
        // 
        ImageFileBrowse_Button.Location = new Point(373, 35);
        ImageFileBrowse_Button.Name = "ImageFileBrowse_Button";
        ImageFileBrowse_Button.Size = new Size(22, 20);
        ImageFileBrowse_Button.TabIndex = 24;
        ImageFileBrowse_Button.Text = "…";
        ImageFileBrowse_Button.UseVisualStyleBackColor = true;
        ImageFileBrowse_Button.Click += ImageFileBrowse_Button_Click;
        // 
        // CompressLvl_Label
        // 
        CompressLvl_Label.Location = new Point(12, 67);
        CompressLvl_Label.Name = "CompressLvl_Label";
        CompressLvl_Label.Size = new Size(85, 20);
        CompressLvl_Label.TabIndex = 8;
        CompressLvl_Label.Text = "Compression:";
        // 
        // CompressLvl_ComboBox
        // 
        CompressLvl_ComboBox.FormattingEnabled = true;
        CompressLvl_ComboBox.Items.AddRange(new object[] { "None", "XPRESS (Default)", "LZX", "LZMS" });
        CompressLvl_ComboBox.Location = new Point(103, 64);
        CompressLvl_ComboBox.Name = "CompressLvl_ComboBox";
        CompressLvl_ComboBox.Size = new Size(121, 23);
        CompressLvl_ComboBox.TabIndex = 10;
        CompressLvl_ComboBox.SelectedIndexChanged += CompressLvl_ComboBox_SelectedIndexChanged;
        // 
        // OpenFileDialog
        // 
        OpenFileDialog.CheckFileExists = false;
        OpenFileDialog.DefaultExt = "wim";
        OpenFileDialog.Title = "Where to save the WIM file";
        // 
        // PathToImageDialog
        // 
        PathToImageDialog.ShowHiddenFiles = true;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(407, 338);
        Controls.Add(FileAcl_CheckBox);
        Controls.Add(NoRpFix_CheckBox);
        Controls.Add(Verify_CheckBox);
        Controls.Add(DirectoryAcl_CheckBox);
        Controls.Add(SourceDir_Label);
        Controls.Add(ImageFileBrowse_Button);
        Controls.Add(SourceDirBrowse_Button);
        Controls.Add(Cancel_Button);
        Controls.Add(Append_Button);
        Controls.Add(Create_Button);
        Controls.Add(CapturePath_TextBox);
        Controls.Add(CompressLvl_ComboBox);
        Controls.Add(CompressLvl_Label);
        Controls.Add(ImageFile_Label);
        Controls.Add(WimPath_TextBox);
        Location = new Point(15, 15);
        Name = "MainWindow";
        Text = "WIM Configurator";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox WimPath_TextBox;
    private System.Windows.Forms.Label ImageFile_Label;
    private System.Windows.Forms.CheckBox DirectoryAcl_CheckBox;
    private System.Windows.Forms.CheckBox Verify_CheckBox;
    private System.Windows.Forms.CheckBox NoRpFix_CheckBox;
    private System.Windows.Forms.CheckBox FileAcl_CheckBox;
    private System.Windows.Forms.TextBox CapturePath_TextBox;
    private System.Windows.Forms.Label SourceDir_Label;
    private System.Windows.Forms.Button Create_Button;
    private System.Windows.Forms.Button Append_Button;
    private System.Windows.Forms.Button Cancel_Button;
    private System.Windows.Forms.Button SourceDirBrowse_Button;
    private System.Windows.Forms.Button ImageFileBrowse_Button;
    private System.Windows.Forms.Label CompressLvl_Label;
    private System.Windows.Forms.ComboBox CompressLvl_ComboBox;

    #endregion

    private OpenFileDialog OpenFileDialog;
    private FolderBrowserDialog PathToImageDialog;
}