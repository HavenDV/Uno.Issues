using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading;
using ValidationIssue;

namespace UpworkPdfGenerator.Apps.Wpf;

public partial class MainViewModel : ObservableValidator
{
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(
        ErrorMessageResourceType = typeof(ValidationResources),
        ErrorMessageResourceName = nameof(ValidationResources.Required))]
    [Display(
        ResourceType = typeof(ValidationResources),
        Name = nameof(ValidationResources.Username))]
    private string username = string.Empty;

    public string[] Languages { get; } = new[]
    {
        "en-US",
        "de-DE",
        "es-ES",
        "fr-FR",
        "zh-CN",
    };

    [ObservableProperty]
    private string selectedLanguage = string.Empty;

    public MainViewModel()
    {
        SelectedLanguage = Languages.First();
    }

    partial void OnSelectedLanguageChanged(string value)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(value);
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(value);

        ValidateAllProperties();
    }
}
