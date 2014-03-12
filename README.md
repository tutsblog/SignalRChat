aparently, the NuGet package from VS package manage does not create the correct version references to OWIN libs. Running the following command from te NuGet console fixed the issue:

PM> Install-Package Microsoft.Owin -Version 2.1.0
PM> Install-Package Microsoft.Owin.Security -Version 2.1.0

Note that this will uninstall the previous versions automatically.