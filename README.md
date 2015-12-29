#Changelog

##December 29, 2015
- Enabled SslProtocols Enumeration including TLS 1.2 (https://msdn.microsoft.com/en-us/library/system.security.authentication.sslprotocols(v=vs.110).aspx).
- Updated for Framework 4.5.1

##August 2nd, 2012
- Update to viddler.encoding.getStatus2 to fix an issue with "Instance validation error: 'not ready' is not a valid value for VideoStatus."

#General Information

Debug - binaries compiled using debug mode
- ViddlerV2.dll - compiled .NET wrapper library.
- ViddlerV2.pdb - debugging and project state information to help developers debug their applications, which reference the wrapper library.
- ViddlerV2.xml - XML documentation file - when used in Visual Studio - provides detailed description of classes and class members available in the wrapper library. It is also known as IntelliSense.

Demo
- ViddlerDemo.exe - simple demonstrator application, which uses .NET wrapper library.
- ViddlerV2.dll - compiled .NET wrapper library.

Doc
- ViddlerV2.chm - documentation, developer's help - describes all classes and class members available in the wrapper library; includes simple "how to start code sample"; describes how to configure the service.

Release - binaries compiled using release mode (optimized for high performance)
- ViddlerV2.dll - compiled .NET wrapper library.
- ViddlerV2.xml - XML documentation file - when used in Visual Studio - provides detailed description of classes and class members available in the wrapper library. It is also known as IntelliSense.

Source - source code of both, the wrapper library and demonstator application.

Updates:
	v1.2 - Updated for SslProtocols thru TLS 1.2
	v1.1 - Updated project to Visual Studio 2010
		 - Changed Viddler.Videos.GetByUser to provide parameter for Tags
			- Added optional parameter "tags" to preserve backwards compatiblity without adding overload
			- "tags" parameter must be comma separated list if more than one tag is desired
	v1.0 - Initial Release
