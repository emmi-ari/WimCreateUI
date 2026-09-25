namespace DismImagingGUI;

partial class Form1
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
        imageFile_TextBox = new System.Windows.Forms.TextBox();
        imageFile_Label = new System.Windows.Forms.Label();
        checkIntegrity_CheckBox = new System.Windows.Forms.CheckBox();
        verify_CheckBox = new System.Windows.Forms.CheckBox();
        noRpFix_CheckBox = new System.Windows.Forms.CheckBox();
        extendedAttributes_CheckBox = new System.Windows.Forms.CheckBox();
        sourceDir_TextBox = new System.Windows.Forms.TextBox();
        sourceDir_Label = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        sourceDirBrowse_Button = new System.Windows.Forms.Button();
        imageFileBrowse_Button = new System.Windows.Forms.Button();
        compressLvl_Label = new System.Windows.Forms.Label();
        compressLvl_ComboBox = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // imageFile_TextBox
        // 
        imageFile_TextBox.Location = new System.Drawing.Point(103, 12);
        imageFile_TextBox.Name = "imageFile_TextBox";
        imageFile_TextBox.Size = new System.Drawing.Size(264, 23);
        imageFile_TextBox.TabIndex = 0;
        imageFile_TextBox.Visible = false;
        // 
        // imageFile_Label
        // 
        imageFile_Label.Location = new System.Drawing.Point(12, 15);
        imageFile_Label.Name = "imageFile_Label";
        imageFile_Label.Size = new System.Drawing.Size(85, 20);
        imageFile_Label.TabIndex = 1;
        imageFile_Label.Text = "Save image to:";
        imageFile_Label.Visible = false;
        // 
        // checkIntegrity_CheckBox
        // 
        checkIntegrity_CheckBox.Location = new System.Drawing.Point(43, 121);
        checkIntegrity_CheckBox.Name = "checkIntegrity_CheckBox";
        checkIntegrity_CheckBox.Size = new System.Drawing.Size(153, 24);
        checkIntegrity_CheckBox.TabIndex = 14;
        checkIntegrity_CheckBox.Text = "Disable Directory ACL";
        checkIntegrity_CheckBox.UseVisualStyleBackColor = true;
        checkIntegrity_CheckBox.Visible = false;
        // 
        // verify_CheckBox
        // 
        verify_CheckBox.Location = new System.Drawing.Point(43, 211);
        verify_CheckBox.Name = "verify_CheckBox";
        verify_CheckBox.Size = new System.Drawing.Size(118, 24);
        verify_CheckBox.TabIndex = 15;
        verify_CheckBox.Text = "Verify image files";
        verify_CheckBox.UseVisualStyleBackColor = true;
        verify_CheckBox.Visible = false;
        // 
        // noRpFix_CheckBox
        // 
        noRpFix_CheckBox.Location = new System.Drawing.Point(43, 181);
        noRpFix_CheckBox.Name = "noRpFix_CheckBox";
        noRpFix_CheckBox.Size = new System.Drawing.Size(236, 24);
        noRpFix_CheckBox.TabIndex = 16;
        noRpFix_CheckBox.Text = "Disable fixing of junctions and symlinks";
        noRpFix_CheckBox.UseVisualStyleBackColor = true;
        noRpFix_CheckBox.Visible = false;
        // 
        // extendedAttributes_CheckBox
        // 
        extendedAttributes_CheckBox.Location = new System.Drawing.Point(43, 151);
        extendedAttributes_CheckBox.Name = "extendedAttributes_CheckBox";
        extendedAttributes_CheckBox.Size = new System.Drawing.Size(168, 24);
        extendedAttributes_CheckBox.TabIndex = 17;
        extendedAttributes_CheckBox.Text = "Disable File ACL";
        extendedAttributes_CheckBox.UseVisualStyleBackColor = true;
        extendedAttributes_CheckBox.Visible = false;
        // 
        // sourceDir_TextBox
        // 
        sourceDir_TextBox.Location = new System.Drawing.Point(103, 41);
        sourceDir_TextBox.Name = "sourceDir_TextBox";
        sourceDir_TextBox.Size = new System.Drawing.Size(264, 23);
        sourceDir_TextBox.TabIndex = 18;
        sourceDir_TextBox.Visible = false;
        // 
        // sourceDir_Label
        // 
        sourceDir_Label.Location = new System.Drawing.Point(12, 44);
        sourceDir_Label.Name = "sourceDir_Label";
        sourceDir_Label.Size = new System.Drawing.Size(85, 20);
        sourceDir_Label.TabIndex = 19;
        sourceDir_Label.Text = "Path to image:";
        sourceDir_Label.Visible = false;
        sourceDir_Label.Click += sourceDir_Label_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(299, 302);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(96, 24);
        button1.TabIndex = 20;
        button1.Text = "Create Image";
        button1.UseVisualStyleBackColor = true;
        button1.Visible = false;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(196, 302);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(96, 24);
        button2.TabIndex = 21;
        button2.Text = "Append Image";
        button2.UseVisualStyleBackColor = true;
        button2.Visible = false;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(94, 302);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(96, 24);
        button3.TabIndex = 22;
        button3.Text = "Cancel";
        button3.UseVisualStyleBackColor = true;
        button3.Visible = false;
        // 
        // sourceDirBrowse_Button
        // 
        sourceDirBrowse_Button.Location = new System.Drawing.Point(373, 41);
        sourceDirBrowse_Button.Name = "sourceDirBrowse_Button";
        sourceDirBrowse_Button.Size = new System.Drawing.Size(22, 20);
        sourceDirBrowse_Button.TabIndex = 23;
        sourceDirBrowse_Button.Text = "…";
        sourceDirBrowse_Button.UseVisualStyleBackColor = true;
        sourceDirBrowse_Button.Visible = false;
        // 
        // imageFileBrowse_Button
        // 
        imageFileBrowse_Button.Location = new System.Drawing.Point(373, 12);
        imageFileBrowse_Button.Name = "imageFileBrowse_Button";
        imageFileBrowse_Button.Size = new System.Drawing.Size(22, 20);
        imageFileBrowse_Button.TabIndex = 24;
        imageFileBrowse_Button.Text = "…";
        imageFileBrowse_Button.UseVisualStyleBackColor = true;
        imageFileBrowse_Button.Visible = false;
        // 
        // compressLvl_Label
        // 
        compressLvl_Label.Location = new System.Drawing.Point(12, 74);
        compressLvl_Label.Name = "compressLvl_Label";
        compressLvl_Label.Size = new System.Drawing.Size(85, 20);
        compressLvl_Label.TabIndex = 8;
        compressLvl_Label.Text = "Compression:";
        // 
        // compressLvl_ComboBox
        // 
        compressLvl_ComboBox.FormattingEnabled = true;
        compressLvl_ComboBox.Items.AddRange(new object[] { "None", "XPRESS (Default)", "LZX", "LZMS" });
        compressLvl_ComboBox.Location = new System.Drawing.Point(103, 71);
        compressLvl_ComboBox.Name = "compressLvl_ComboBox";
        compressLvl_ComboBox.Size = new System.Drawing.Size(121, 23);
        compressLvl_ComboBox.TabIndex = 10;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(407, 338);
        Controls.Add(sourceDir_Label);
        Controls.Add(imageFileBrowse_Button);
        Controls.Add(sourceDirBrowse_Button);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(sourceDir_TextBox);
        Controls.Add(extendedAttributes_CheckBox);
        Controls.Add(noRpFix_CheckBox);
        Controls.Add(verify_CheckBox);
        Controls.Add(checkIntegrity_CheckBox);
        Controls.Add(compressLvl_ComboBox);
        Controls.Add(compressLvl_Label);
        Controls.Add(imageFile_Label);
        Controls.Add(imageFile_TextBox);
        Location = new System.Drawing.Point(15, 15);
        Text = "WIM Configurator";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox imageFile_TextBox;
    private System.Windows.Forms.Label imageFile_Label;
    private System.Windows.Forms.CheckBox checkIntegrity_CheckBox;
    private System.Windows.Forms.CheckBox verify_CheckBox;
    private System.Windows.Forms.CheckBox noRpFix_CheckBox;
    private System.Windows.Forms.CheckBox extendedAttributes_CheckBox;
    private System.Windows.Forms.TextBox sourceDir_TextBox;
    private System.Windows.Forms.Label sourceDir_Label;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button sourceDirBrowse_Button;
    private System.Windows.Forms.Button imageFileBrowse_Button;
    private System.Windows.Forms.Label compressLvl_Label;
    private System.Windows.Forms.ComboBox compressLvl_ComboBox;

    #endregion
}