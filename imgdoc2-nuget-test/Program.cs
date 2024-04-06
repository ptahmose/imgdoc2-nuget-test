// See https://aka.ms/new-console-template for more information

using ImgDoc2Net.Implementation;

var versionInfo = ImgDoc2Global.GetVersionInfo();
Console.WriteLine("(Native) ImgDoc2 Version");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine($"Version: {versionInfo.NativeLibraryVersion.Major}.{versionInfo.NativeLibraryVersion.Minor}.{versionInfo.NativeLibraryVersion.Patch}");
Console.WriteLine($"Compiler Identification: {versionInfo.NativeLibraryVersion.CompilerIdentification}");
Console.WriteLine($"Build Type: {versionInfo.NativeLibraryVersion.BuildType}");
Console.WriteLine($"Repository URL: {versionInfo.NativeLibraryVersion.RepositoryUrl}");
Console.WriteLine($"Repository Branch: {versionInfo.NativeLibraryVersion.RepositoryBranch}");
Console.WriteLine($"Repository Tag: {versionInfo.NativeLibraryVersion.RepositoryTag}");