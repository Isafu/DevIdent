using System;
using System.IO;

namespace DevIdent.Classes
{
    public struct Browser
    {
        private static readonly string User = Environment.UserName;

        #region Chrome

        #region Папки хром

        public static readonly DirectoryInfo[] directoryOfChrome =
        {
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache"),
            new DirectoryInfo("C:\\Users\\" + User +
                "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Storage\\ext\\"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\File System"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Extension State"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Session Storage"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Sessions"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\IndexedDB"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\ShaderCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\GrShaderCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Service Worker"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\ShaderCache")
        };

        #endregion Папки хром

        #region Файлы хром

        public static readonly string[] chromeCachePathes =
        {
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Affiliation Database-journal",
            "C:\\Users\\" + User +
            "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Safe Browsing Cookies-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\DownloadMetadata",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\History",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\History Provider Cache",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\History-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cookies",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cookies-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Visited Links",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data For Account",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Media History",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Web Data",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Web Data-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Action Predictor",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Top Sites",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Favicons-journal",
            "C:\\Users\\" + User +
            "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data For Account-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Media History-journal",
            "C:\\Users\\" + User +
            "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Action Predictor-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Reporting and NEL-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Top Sites-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\QuotaManager-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Safe Browsing Cookies-journal",
            "C:\\Users\\" + User + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Shortcuts-journal",
            "C:\\Users\\" + User +
            "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\heavy_ad_intervention_opt_out.db-journal"
        };

        #endregion Файлы хром

        #endregion Chrome

        #region Opera GX

        #region Папки GX

        public static readonly DirectoryInfo[] directoryOfGx =
        {
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\ShaderCache\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Opera Software\\Opera GX Stable\\Cache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Sessions"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Session Storage"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\IndexedDB"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Extension State"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Service Worker"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\File System"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\GrShaderCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Jump List Icons"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Jump List IconsOld")
        };

        #endregion Папки GX

        #region Файлы GX

        public static readonly string[] operaGxCachePathes =
        {
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Cookies",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Cookies-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\History",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\History Provider Cache",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\History-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Login Data",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Visited Links",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Network Action Predictor",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Favicons-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Login Data-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Media History-journal",
            "C:\\Users\\" + User +
            "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Network Action Predictor-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\QuotaManager-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Reporting and NEL-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Shortcuts-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera GX Stable\\Web Data-journal"
        };

        #endregion Файлы GX

        #endregion Opera GX

        #region Opera

        #region Список папок

        public static readonly DirectoryInfo[] directoryOfOpera =
        {
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\IndexedDB"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\File System"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Session Storage"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Sessions"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Extension State"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Opera Software\\Opera Stable\\Cache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\ShaderCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Jump List Icons"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Jump List IconsOld"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Jump List Icons"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Jump List IconsOld"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\ShaderCache\\GPUCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Session Storage"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Extension State"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Sessions")
        };

        #endregion Список папок

        #region Список файлов

        public static readonly string[] operaCachePathes =
        {
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Cookies-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Favicons-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\History-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Login Data-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Media History-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Network Action Predictor-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\QuotaManager-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Reporting and NEL-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Shortcuts-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Web Data-journal",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Visited Links",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Network Action Predictor",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\History Provider Cache",
            "C:\\Users\\" + User + "\\AppData\\Roaming\\Opera Software\\Opera Stable\\Login Data"
        };

        #endregion Список файлов

        #endregion Opera

    }
}