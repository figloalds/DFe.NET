echo off

del /f /q dfenet.version
rem git rev-list --count master >> dfenet.version
echo 2082> dfenet.version
set /p revision=< dfenet.version
set /p rev=<rev
set /A rev=rev+1
echo %rev% > rev

set args=-o .\_nuget -p:PackageVersion=1.0.%revision%.%rev%

dotnet pack MDFe.Classes %args%
dotnet pack MDFe.Servicos %args%
dotnet pack MDFe.Utils %args%
dotnet pack MDFe.Wsdl %args%
dotnet pack DFe.Classes %args%
dotnet pack DFe.Utils %args%
dotnet pack DFe.Wsdl %args%
dotnet pack NFe.Classes %args%
dotnet pack NFe.Servicos %args%
dotnet pack NFe.Utils %args%
dotnet pack NFe.Wsdl %args%
dotnet pack NFe.Wsdl.Standard %args%
dotnet pack NFe.Danfe.Base %args%
dotnet pack NFe.Danfe.OpenFast %args%

if errorlevel 1 (
	echo BUILD PROCESS FAILED.
) else (
	echo BUILD PROCESS SUCCEDED!
)

copy /d /v /n /y .\_nuget\* ..\NugetLocal