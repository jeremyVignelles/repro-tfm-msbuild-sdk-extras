# repro-tfm-msbuild-sdk-extras

To repro:

- Clone this project
- `dotnet build`
- `./bin/Debug/net6.0/TestTFM.exe`: See that only NET_6_0 is shown
- `./bin/Debug/net6.0-windows/TestTFM.exe`: See that no message is shown

Expected:
```
NET6_0
NET6_0_OR_GREATER
```

for both TFM