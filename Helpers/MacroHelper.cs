using Microsoft.Win32;

namespace CommandAliasing.Helpers;

public static class MacroHelper
{
    private static readonly string MacroDirectory =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Macros");

    private static readonly string MacroFile = Path.Combine(MacroDirectory, "macros.doskey");

    private static void EnsureMacroDirectoryExists()
    {
        if (!Directory.Exists(MacroDirectory))
            Directory.CreateDirectory(MacroDirectory);
    }

    private static void EnsureMacroFileExists()
    {
        if (File.Exists(MacroFile)) return;
        using (File.Create(MacroFile))
        {
        }
    }

    public static Dictionary<string, string> GetMacros()
    {
        EnsureMacroFileExists();
        return File.ReadAllLines(MacroFile)
            .Select(line => line.Split('='))
            .Where(parts => parts.Length == 2)
            .ToDictionary(parts => parts[0], parts => parts[1]);
    }

    public static string Install()
    {
        EnsureMacroDirectoryExists();
        EnsureMacroFileExists();

        var doskeyCommand = $"doskey /macrofile={MacroFile}";
        using var key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Command Processor");
        key?.SetValue("Autorun", doskeyCommand);

        return MacroFile;
    }

    public static string Uninstall()
    {
        using var key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Command Processor", true);
        if (key?.GetValue("Autorun") != null)
            key.DeleteValue("Autorun");

        return MacroFile;
    }

    public static bool IsInstalled()
    {
        using var key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Command Processor");
        var autorun = key?.GetValue("Autorun")?.ToString();
        return autorun != null;
    }

    public static void UpdateMacros(Dictionary<string, string> macros)
    {
        EnsureMacroDirectoryExists();
        EnsureMacroFileExists();

        var lines = macros.Select(kv => $"{kv.Key}={kv.Value}");
        File.WriteAllLines(MacroFile, lines);
    }
}