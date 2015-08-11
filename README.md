# SampleError

This is just sample error project for issue with SQLClient on ASP.NET 5 project.

Steps to reproduce:
* Open solution
* Restore packages and re-build
* Run integration test:
Test FullName:	Tests.Integration.Class1.TestMethod

You should get error:
	System.IO.FileNotFoundException : Could not load file or assembly 'System.Data.SqlClient, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.


