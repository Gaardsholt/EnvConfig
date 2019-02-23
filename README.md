[![Codacy Badge](https://api.codacy.com/project/badge/Grade/58108f010a954182a36294ef6172ba59)](https://app.codacy.com/app/Gaardsholt/EnvConfig?utm_source=github.com&utm_medium=referral&utm_content=Gaardsholt/EnvConfig&utm_campaign=Badge_Grade_Dashboard)
[![Sonarcloud Status](https://sonarcloud.io/api/project_badges/measure?project=Gaardsholt_EnvConfig&metric=alert_status)](https://sonarcloud.io/dashboard?id=Gaardsholt_EnvConfig)
[![CircleCI](https://circleci.com/gh/Gaardsholt/EnvConfig.svg?style=svg)](https://circleci.com/gh/Gaardsholt/EnvConfig)

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
