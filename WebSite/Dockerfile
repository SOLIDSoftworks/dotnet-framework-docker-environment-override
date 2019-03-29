FROM microsoft/dotnet-framework:4.7.2-sdk AS publish

# if your company or enterprise is using ssl interception, this is where you need to install certs for the egress
# RUN Import-Certificate -FilePath <path> -CertStoreLocation <location>

WORKDIR /src
COPY . .
RUN nuget restore DockerDemo.sln
RUN msbuild DockerDemo.sln /p:Configuration=Release /p:DeployOnBuild=True /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:DeleteExistingFiles=True /p:publishUrl=c:\publish

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.7.2
# Copy a prebuilt .Net IIS ServiceMonitor to replace the default one.
# https://solidsoft.works/2019/03/25/porting-iis-servicemonitor-to-net/
# https://github.com/SOLIDSoftworks/iis-service-monitor
COPY ./ServiceMonitor .
COPY --from=publish /publish /inetpub/wwwroot