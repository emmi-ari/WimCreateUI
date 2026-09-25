using Microsoft.Wim;

namespace DismImagingGUI;

public enum ImagingMode : uint
{
    /// <summary>
    /// Makes a new image file. If the specified file already exists, the function fails.
    /// </summary>
    Create = 1,
    /// <summary>
    /// Opens the image file. If the file does not exist, the function fails.
    /// </summary>
    Append = 3
}

public static class DismApiFunctions
{
    internal static void CreateWimImage(string capturePath, string wimPath, bool directoryAcl, bool fileAcl, bool reparseFix, bool verify, WimCompressionType compression, ImagingMode imagingMode)
    {
        if (!Directory.Exists(capturePath)) 
            throw new DirectoryNotFoundException("Source directory does not exist or is inaccessible.");

        dynamic options = (verify ? 2u : 0u) + (directoryAcl ? 16u : 0u) + (fileAcl ? 32u : 0u) + (reparseFix ? 256u : 0u);
        WimCreateFileOptions fileCreationOptions = WimCreateFileOptions.ShareWrite + (verify ? 2u : 0);
        WimFileAccess accessMode = (int)imagingMode == 1 ? WimFileAccess.Write : WimFileAccess.Mount;

        using WimHandle handle = WimgApi.CreateFile(wimPath, WimFileAccess.Write, (WimCreationDisposition)imagingMode, fileCreationOptions, compression);

        switch (imagingMode)
        {
            case ImagingMode.Create:
                WimgApi.CaptureImage(handle, capturePath, (WimCaptureImageOptions)options).Close();
                return;
            case ImagingMode.Append:
                var mnt = Directory.CreateDirectory(@".\wim_mount");
                try
                {
                    WimgApi.MountImage(imageHandle: handle, mountPath: mnt.FullName, options: WimMountImageOptions.Fast | (WimMountImageOptions)options);
                    WimgApi.CommitImageHandle(handle, true, (WimCommitImageOptions)options).Close();
                }
                finally
                {
                    if (Directory.Exists(mnt.FullName))
                        Directory.Delete(mnt.FullName);
                }
                return;
        }
    }
}