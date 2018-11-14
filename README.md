[![Sonarcloud Status](https://sonarcloud.io/api/project_badges/measure?project=Gaardsholt_barcoder&metric=alert_status)](https://sonarcloud.io/dashboard?id=Gaardsholt_barcoder)

# EnvConfig
Simple environment variables reader for .NET

Use it like this:
```csharp
public class MyClass : EnvSettings
{
    public string MyUsername { get; set; }
    public string MyPassword { get; set; }
}
```
