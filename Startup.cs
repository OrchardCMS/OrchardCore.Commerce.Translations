using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Commerce.Translations.Services;
using OrchardCore.Localization;
using OrchardCore.Modules;

namespace OrchardCore.Commerce.Translations;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<ITranslationProvider, EmbeddedPoTranslationsProvider>();
    }
}