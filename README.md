# Unit Testing con C# y .NET
## Resumen
Resumen de **TDD** vs **Unit Testing**:

El ```TDD``` (Test Driven Development) y las ```Unit Testing``` (Pruebas Unitarias) son dos pr�cticas relacionadas 
pero diferentes en el desarrollo de software.

El ```TDD``` es una metodolog�a de desarrollo de software en la que se enfatiza la creaci�n de pruebas antes de 
escribir el c�digo de la aplicaci�n.

Las ```pruebas unitarias``` son una pr�ctica dentro del desarrollo de software en la que se crean pruebas espec�ficas para cada componente o unidad individual del c�digo (por ejemplo, una funci�n, m�todo o clase) aisladamente.

## Lecturas
- [F.I.R.S.T principles for testing](https://medium.com/@tasdikrahman/f-i-r-s-t-principles-of-testing-1a497acda8d6)
- [xUnit.net Docs - Comparing xUnit.net to other frameworks](https://xunit.net/docs/comparisons)

## Nuget Packages
- Instalar coverlet.console: ```dotnet tool install --global coverlet.console --version 6.0.0```
- Ejecutar comando para las coberturas de las pruebas: ```dotnet test /p:CollectCoverage=true```