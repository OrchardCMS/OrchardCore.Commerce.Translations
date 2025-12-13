using System.IO;
using System.Linq;
using Microsoft.Extensions.FileProviders;
using OrchardCore.Localization;
using OrchardCore.Localization.PortableObject;
using OrchardCore.Modules;

namespace OrchardCore.Commerce.Translations.Services;

public class EmbeddedPoTranslationsProvider: ITranslationProvider
{
    private readonly PoParser _parser = new();

    public void LoadTranslations(string cultureName, CultureDictionary dictionary)
    {
        var assembly = typeof(EmbeddedPoTranslationsProvider).Assembly;
        var resourceNames = assembly
            .GetManifestResourceNames()
            .Where(name => name.EndsWithOrdinalIgnoreCase(".po"));

        foreach (var name in resourceNames)
        {
            using var stream = assembly.GetManifestResourceStream(name);
            using var reader = new StreamReader(stream);
            
            dictionary.MergeTranslations(_parser.Parse(reader));
        }
    }
}