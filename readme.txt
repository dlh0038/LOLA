Lunch Ordering Liason App (LOLA)

first time setup:
    navigate to "C:\Users\<user>\AppData\Roaming\NuGet\NuGet.Config"
    edit NuGet.Config file to specify proxies:
        <?xml version="1.0" encoding="utf-8"?>
        <configuration>
        <packageSources>
            <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
        </packageSources>
        <config>
            <add key="http_proxy" value="" /> <!--proxy data redacted since we are using public repo -->
            <add key="http_proxy.user" value="" />
            <add key="no_proxy" value="" />
        </config>
        </configuration>

To run, navigate to Server directory and execute "dotnet watch run"