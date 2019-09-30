SET PACKAGE_VERSION="2.0.0"

mkdir .\src\nuget
dotnet pack src/HarSharp/HarSharp.csproj -c release --no-build --output ../nuget /p:PackageVersion=%PACKAGE_VERSION%