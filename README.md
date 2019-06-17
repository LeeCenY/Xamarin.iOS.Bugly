# Xamarin.iOS.Bugly
Bugly for Xamarin.iOS bind

### NuGet 安装
- [Xamarin.iOS.Bugly](https://www.nuget.org/packages/Xamarin.iOS.Bugly) [![NuGet](https://img.shields.io/nuget/v/Xamarin.iOS.Bugly.svg?label=NuGet)](https://www.nuget.org/packages/Xamarin.iOS.Bugly)


- #### 在 ```AppDelegate.cs``` 的 ```FinishedLaunching``` 函数中注册ID


- #### 注册
```
public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
{
    //注册,请填写您的AppID
    Bugly.Bugly.StartWithAppId("AppID");

    return true;
}
```
