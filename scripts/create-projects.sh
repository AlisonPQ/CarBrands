#!/usr/bin/env bash
green="\033[1;32m"
reset="\033[m"

echo "About to create the directory"

echo -e "${green}Creating solution and projects${reset}"

mkdir src
cd src

mkdir Presentation
mkdir BusinessLogic
mkdir DataSource

dotnet new sln -n CarBrands

cd Presentation
dotnet new webapi -n CarBrands.Presentation.WebService --use-controllers

cd ../BusinessLogic
dotnet new classlib -n CarBrands.BusinessLogic
dotnet new classlib -n CarBrands.BusinessLogic.Impl
dotnet new classlib -n CarBrands.BusinessLogic.Stub

 cd ../DataSource
 dotnet new classlib -n CarBrands.DataSource
 dotnet new classlib -n CarBrands.DataSource.PostgreSQL
 dotnet new classlib -n CarBrands.DataSource.Memory

 cd ..
 dotnet new classlib -n CarBrands.Models

 echo -e "${green}Adding projects to the solution${reset}"

 dotnet sln add Presentation/CarBrands.Presentation.WebService/CarBrands.Presentation.WebService.csproj

 dotnet sln add BusinessLogic/CarBrands.BusinessLogic/CarBrands.BusinessLogic.csproj
 dotnet sln add BusinessLogic/CarBrands.BusinessLogic.Impl/CarBrands.BusinessLogic.Impl.csproj
 dotnet sln add BusinessLogic/CarBrands.BusinessLogic.Stub/CarBrands.BusinessLogic.Stub.csproj

 dotnet sln add DataSource/CarBrands.DataSource/CarBrands.DataSource.csproj
 dotnet sln add DataSource/CarBrands.DataSource.PostgreSQL/CarBrands.DataSource.PostgreSQL.csproj
 dotnet sln add DataSource/CarBrands.DataSource.Memory/CarBrands.DataSource.Memory.csproj

 dotnet sln add CarBrands.Models/CarBrands.Models.csproj

echo -e "${green}Setting up project dependancies${reset}"

 cd Presentation/CarBrands.Presentation.WebService
 dotnet add reference ../../BusinessLogic/CarBrands.BusinessLogic/CarBrands.BusinessLogic.csproj
 dotnet add reference ../../BusinessLogic/CarBrands.BusinessLogic.Impl/CarBrands.BusinessLogic.Impl.csproj
 
 cd ../../BusinessLogic/CarBrands.BusinessLogic
 dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj

cd ../../BusinessLogic/CarBrands.BusinessLogic.Impl
dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj
dotnet add reference ../../BusinessLogic/CarBrands.BusinessLogic/CarBrands.BusinessLogic.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource/CarBrands.DataSource.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource.PostgreSQL/CarBrands.DataSource.PostgreSQL.csproj

cd ../../BusinessLogic/CarBrands.BusinessLogic.Stub
dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj
dotnet add reference ../../BusinessLogic/CarBrands.BusinessLogic/CarBrands.BusinessLogic.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource/CarBrands.DataSource.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource.Memory/CarBrands.DataSource.Memory.csproj

cd ../../DataSource/CarBrands.DataSource
dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj
 
cd ../../DataSource/CarBrands.DataSource.PostgreSQL
dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource/CarBrands.DataSource.csproj

cd ../../DataSource/CarBrands.DataSource.Memory
dotnet add reference ../../CarBrands.Models/CarBrands.Models.csproj
dotnet add reference ../../DataSource/CarBrands.DataSource/CarBrands.DataSource.csproj

echo -e "${green}Executing dotnet restore${reset}"
dotnet restore

echo -e "${green}Finished!${reset}"
