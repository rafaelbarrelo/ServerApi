FROM microsoft/dotnet:2.0-runtime

RUN printf "deb http://ftp.us.debian.org/debian jessie main\n" >> /etc/apt/sources.list

COPY ./app /app
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "ServerApi.dll"]
