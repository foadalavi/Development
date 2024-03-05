# For non-web application:
### Project Setting:
```
<EnableSdkContainerSupport>true</EnableSdkContainerSupport>
```
### Publish Command:
```
dotnet publish --os linux --arch x64 -c Release /t:PublishContainer
```


# For web application
### Publish Command:
```
dotnet publish --os linux --arch x64 -c Release /p:PublishProfile=DefaultContainer
```

# Other Settings
```
<publishtrimmed>true</publishtrimmed>
<ContainerImageName>ImageName</ContainerImageName>
<ContainerImageTag>1.0.0</ContainerImageTag>
<ContainerFamily>jammy-chiseled</ContainerFamily>
```