專案名稱
Razor
簡介
● 語言 :C#
● 主旨 :
○ 用Razor建立網頁





快速開始
環境建立
1. NuGet安裝westwind.livereload，安裝完後，在start up 裡面的ConfigureServices()複製貼上
	services.AddLiveReload(config =>
　　　{
   	 // optional - use config instead
   	 //config.LiveReloadEnabled = true;
  	  //config.FolderToMonitor = 	Path.GetFullname(Path.Combine(Env.ContentRootPath,"..")) ;
　　　});

　　　// for ASP.NET Core 3.0 add Runtime Razor Compilation
　　　// services.AddRazorPages().AddRazorRuntimeCompilation();
　　　// services.AddMvc().AddRazorRuntimeCompilation();

    2.NuGet安裝netcore.runtimecompilation




專案建立
方式A
1. Visual Studio 新增ASP.Net專案(ASP.NETCore)

