using System.IO;
using System.Linq;
using OrchardCore.Localization;
using OrchardCore.Localization.PortableObject;
using OrchardCore.Modules;

namespace OrchardCore.Commerce.Translations.Services;

/// <summary>
/// Loads translations from .po files embedded in this project's DLL.
/// </summary>
public class EmbeddedPoTranslationsProvider: ITranslationProvider
{
    private const string Prefix = "OrchardCore.Commerce.Translations.Localization>";
    
    private readonly PoParser _parser = new();

    public void LoadTranslations(string cultureName, CultureDictionary dictionary)
    {
        if (string.IsNullOrEmpty(cultureName)) return;
        
        var assembly = typeof(EmbeddedPoTranslationsProvider).Assembly;
        var resourceNames = assembly
            .GetManifestResourceNames()
            .Where(name => name.StartsWithOrdinalIgnoreCase(Prefix + cultureName) && name.EndsWith(".po"));

        foreach (var name in resourceNames)
        {
            using var stream = assembly.GetManifestResourceStream(name);
            using var reader = new StreamReader(stream);
            
            dictionary.MergeTranslations(_parser.Parse(reader));
        }
    }
}
