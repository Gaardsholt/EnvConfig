[![Sonarcloud Status](https://sonarcloud.io/api/project_badges/measure?project=Gaardsholt_EnvConfig&metric=alert_status)](https://sonarcloud.io/dashboard?id=Gaardsholt_EnvConfig)
[![CircleCI](https://circleci.com/gh/Gaardsholt/EnvConfig.svg?style=svg)](https://circleci.com/gh/Gaardsholt/EnvConfig)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FGaardsholt%2FEnvConfig.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2FGaardsholt%2FEnvConfig?ref=badge_shield)

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


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FGaardsholt%2FEnvConfig.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2FGaardsholt%2FEnvConfig?ref=badge_large)