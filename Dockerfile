FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppBuilder
COPY PatternAppBuilder . 

RUN dotnet restore
RUN dotnet publish "PatternAppBuilder.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppBuilder.dll" ]