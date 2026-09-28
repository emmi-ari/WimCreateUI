using System.ComponentModel;

namespace DismImagingGUI;

internal static class Program
{
    private static string _wimLocation;
    private static string _capturePath;
    private static int _compression = 1;
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
            SetArguments(args);
            Application.Run(new MainWindow(_wimLocation, _capturePath, _compression, _dirAcl, _fileAcl, _noRpFix, _verify));
        }
        else
        {
            Application.Run(new MainWindow());
        }
    }

    private static void SetArguments(string[] args)
    {
        _wimLocation = string.Empty;
        _capturePath = string.Empty;
        for (int i = 0; i < args.Length; i++)
        {
            string argS = args[i].SerializeArg().TrimStart('/').ToUpper();
            string subArgS = string.Empty;
            try
            { subArgS = args[i + 1].SerializeArg(); }
            catch (IndexOutOfRangeException) { }
            switch (argS)
            {
                case "WIMPATH":
                    SetArgument(ref _wimLocation, subArgS, string.Empty, ref i);
                    continue;

                case "CAPTUREPATH":
                    SetArgument(ref _capturePath, subArgS, string.Empty, ref i);
                    continue;

                case "COMPRESSION":
                    SetArgument(ref _compression, subArgS, 1, ref i);
                    continue;

                case "DIRACL":
                    SetArgument(ref _dirAcl, subArgS, true, ref i);
                    continue;

                case "FILEACL":
                    SetArgument(ref _fileAcl, subArgS, true, ref i);
                    continue;

                case "NORPFIX":
                    SetArgument(ref _noRpFix, subArgS, true, ref i);
                    continue;

                case "VERIFY":
                    SetArgument(ref _verify, subArgS, true, ref i);
                    continue;

                default:
                    throw new ArgumentException($"{argS} is not a valid parameter.");
            }
        }
    }

    private static void SetArgument<T>(ref T input, string arg, T defaultValue, ref int i, bool throwException = false)
    {
        try
        {
            if (string.IsNullOrEmpty(arg.ToString()) || arg.StartsWith("/"))
                throw new Exception("Todo I guess");

            input = (T)TypeDescriptor.GetConverterFromRegisteredType(typeof(T)).ConvertFromString(arg);
            i++;
        }
        catch (Exception)
        {
            input = defaultValue;
            if (throwException)
                throw;
        }
    }

    private static string SerializeArg(this string input)
        => input.Trim().Trim('\u0022'); // \u0022 = " (Quotaion mark)
}