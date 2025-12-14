# Orchard Core Commerce Translations

[![Translated with Crowdin](https://badges.crowdin.net/badge/light/crowdin-on-dark.png)](https://crowdin.com/project/orchard-core-commerce)

All the localization files used for [Orchard Core Commerce](https://github.com/OrchardCMS/OrchardCore.Commerce) (OCC). As a package, it's available from two sources:

- The NuGet packages match the [`OrchardCore.Commerce`](https://www.nuget.org/packages/OrchardCore.Commerce/) package of the same major and minor versions. These are manually published from the [`main`](https://github.com/OrchardCMS/OrchardCore.Commerce.Translations/tree/main) branch.
- [The Cloudsmith packages](https://cloudsmith.io/~orchardcore/repos/commerce/packages/detail/nuget/OrchardCore.Commerce.Translations/latest/) are automatically published whenever the repository is synchronized with Crowdin and has new data in the [`l10n_main`](https://github.com/OrchardCMS/OrchardCore.Commerce.Translations/tree/l10n_main). The versions are not aligned, you can use the latest Translations and OCC packages together.

## Usage

The localizations are delivered as an Orchard Core module.

1. Include the project (either `<ProjectReference>` or `<PacakgeReference>` works) in your main web project.
2. Enable the "Orchard Core Commerce - Translations" feature.

## Translation flow

1. When the `main` branch of the [`OrchardCore.Commerce`](https://www.nuget.org/packages/OrchardCore.Commerce/) repository is updated, .pot files are generated and uploaded to the `main` branch of this repository.
2. Crowdin's GitHub integration periodically scans this repo and updates the template strings in [our project](https://crowdin.com/project/orchard-core-commerce).
3. When new translations are added in Crowdin, its GitHub integration periodically pushes them to the `l10n_main` branch. (This is the customary branch name for such staging branches.)
4. It also creates a pull request form `l10n_main` to `main`. 
5. When `l10n_main` is updated, a new [`OrchardCore.Commerce.Translations`](https://cloudsmith.io/~orchardcore/repos/commerce/packages/detail/nuget/OrchardCore.Commerce.Translations/latest/) prerelease package is published to Cloudsmith.
6. When the pull request is reviewed, it is manually merged into `main`.
7. When a new OCC package is manually released to NuGet, a matching translations package should also be published there.
