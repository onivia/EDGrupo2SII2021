@echo off
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.10
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.10
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.10
dotnet add package Microsoft.Extensions.Configuration --version 5.0.0
dotnet add package Microsoft.Extensions.Configuration.Abstractions --version 5.0.0
dotnet add package Microsoft.Extensions.Configuration.Binder --version 5.0.0
dotnet add package Microsoft.Extensions.Configuration.FileExtensions --version 5.0.0
dotnet add package Microsoft.Extensions.Configuration.Json --version 5.0.0
dotnet add package Newtonsoft.Json --version 13.0.1
dotnet add package System.Configuration.ConfigurationManager --version 5.0.0
dotnet tool install --global dotnet-ef
dotnet ef dbcontext scaffold "Data Source=190.60.208.196,9191;User ID=usuario00;Password=UEAN00$.;Initial Catalog=dbpruebas01;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False" Microsoft.EntityFrameworkCore.SqlServer -o AccesoDatos/dbpruebas01 -c "DBPruebas01Context" -t "Factura" -t "DetalleFactura" -t "OrdenCompra" -t "NotaCredito" --force
