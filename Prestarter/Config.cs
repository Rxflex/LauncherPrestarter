using Prestarter.Downloaders;

namespace Prestarter
{
    internal class Config
    {
        public static string Project = "Darkness";
        public static string Version = "0.1.0";

        public static string LauncherDownloadUrl = "http://launcher.darkness.cc/Launcher.jar";
        
        public static bool DownloadQuestionEnabled = true;
        
        public static bool UseGlobalJava = true;
        public static IRuntimeDownloader JavaDownloader = new CompositeDownloader(new AdoptiumJavaDownloader(), new OpenJFXDownloader(true));
    }
}
