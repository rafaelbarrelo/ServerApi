dotnet restore
dotnet publish -c Release -o ../docker/app -r debian.8-x64 --self-contained true
cp ../docker/*.yml ../docker/app/
