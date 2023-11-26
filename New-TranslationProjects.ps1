$tempalte = Get-Content .\ProjectTemplate.csproj.xml
dotnet new sln

foreach ($directory in (Get-ChildItem Localization -Directory))
{
    $directoryName = $directory.Name

    $culture = ([CultureInfo]$directoryName).Parent
    $name = $culture.Name
    $english = $culture.EnglishName
    $fileName = "OrchardCore.Commerce.Translations.$name.csproj"

    Push-Location Localization
    Move-Item $directoryName $name
    Pop-Location

    $tempalte.Replace('{Name}', $name).Replace('{EnglishName}', $english) | Out-File $fileName
    dotnet sln add $fileName
}
