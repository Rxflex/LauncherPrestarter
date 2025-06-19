using Prestarter.Downloaders;

namespace Prestarter
{
    internal class Config
    {
        public static string Project = "NekoLand";
        public static string Version = "0.1.0";

        public static string LauncherDownloadUrl = "https://launcher.nekoland.io/Launcher.jar";
        
        public static bool DownloadQuestionEnabled = true;
        
        public static bool UseGlobalJava = true;
        public static IRuntimeDownloader JavaDownloader = new CompositeDownloader(new AdoptiumJavaDownloader(), new OpenJFXDownloader(true));
    }
}
