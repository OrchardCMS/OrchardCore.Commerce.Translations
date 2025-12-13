# Orchard Core Commerce Translations

[![Translated with Crowdin](https://badges.crowdin.net/badge/light/crowdin-on-dark.png)](https://crowdin.com/project/orchard-core-commerce)

All the localization files used for [Orchard Core Commerce](https://github.com/OrchardCMS/OrchardCore.Commerce). As a package, it's avaiable from two sources:

- The NuGet packages match the [`OrchardCore.Commerce`](https://www.nuget.org/packages/OrchardCore.Commerce/) package of the same version. These are manually published from the [`main`](https://github.com/OrchardCMS/OrchardCore.Commerce.Translations/tree/main) branch.
- [The Cloudsmith packages](https://cloudsmith.io/~orchardcore/repos/commerce/packages/detail/nuget/OrchardCore.Commerce.Translations/latest/) are automatically published whenever the repository is synchronized with Crowdin and has new data in the [`l10n_main`](https://github.com/OrchardCMS/OrchardCore.Commerce.Translations/tree/l10n_main). The versions are not aligned, you can use the latest Translations and Commerce packages together.

## Usage

The localizations are delivered as an Orchard Core module. Include the package in your main web project, and enable the "Orchard Core Commerce - Translations" feature in the Admin dashboard or in your setup recipe.
