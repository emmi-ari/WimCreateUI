namespace DismImagingGUI;

internal static class Program
{
    private static string _wimLocation;
    private static string _capturePath;
    private static uint _compression = 1;
    private static bool? _dirAcl;
    private static bool? _fileAcl;
    private static bool? _noRpFix;
    private static bool? _verify;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    internal static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();

        if (args.Length == 2 || args.Length == 4 || args.Length >= 6 || args.Length <= 10)
        {
            _wimLocation = string.Empty;
            _capturePath = string.Empty;
            string subArg = string.Empty;
            for (int i = 0; i < args.Length; i++)
            {
                string argument = args[i].Trim().Trim('"');
                switch (argument.TrimStart('/').ToUpper())
                {
                    case "WIMPATH":
                        subArg = args[i + 1].Trim().Trim('"');
                        _wimLocation = subArg;
                        i++;
                        break;

                    case "CAPTUREPATH":
                        subArg = args[i + 1].Trim().Trim('"');
                        _capturePath = subArg;
                        i++;
                        break;

                    case "COMPRESSION":
                        subArg = args[i + 1].Trim().Trim('"');
                        _ = uint.TryParse(subArg, out uint compLvl);
                        _compression = compLvl;
                        i++;
                        break;

                    case "DIRACL":
                        try {
                            _ = bool.TryParse(args[i + 1].Trim(), out bool dirAcl);
                            _dirAcl = dirAcl;
                        }
                        catch (Exception) {
                            _dirAcl = true;
                        }
                        break;

                    case "FILEACL":
                        try
                        {
                            _ = bool.TryParse(args[i + 1].Trim(), out bool fileAcl);
                            _fileAcl = fileAcl;
                        }
                        catch (Exception)
                        {
                            _fileAcl = true;
                        }
                        break;

                    case "NORPFIX":
                        try
                        {
                            _ = bool.TryParse(args[i + 1].Trim(), out bool noRpFix);
                            _noRpFix = noRpFix;
                        }
                        catch (Exception)
                        {
                            _noRpFix = true;
                        }
                        break;

                    case "VERIFY":
                        try
                        {
                            _ = bool.TryParse(args[i + 1].Trim(), out bool verify);
                            _verify = verify;
                        }
                        catch (Exception)
                        {
                            _verify = true;
                        }
                        break;

                    default:
                        throw new ArgumentException($"{argument} is not a valid parameter.");
                }
            }

            Application.Run(new MainWindow(_wimLocation, _capturePath, _compression, _dirAcl, _fileAcl, _noRpFix, _verify));
            return;
        }

        Application.Run(new MainWindow());
    }
}