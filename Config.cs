using P3R.UEToolkit.Template.Configuration;
using System.ComponentModel;

namespace P3R.UEToolkit.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
}