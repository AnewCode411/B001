using HybridCLR.Editor.Installer;
using UnityEditor;
using UnityEngine;

namespace HybridCLR.Editor.Settings
{
    public static class MenuProvider
    {

        [MenuItem("Tools/HybridCLR/About HybridCLR", priority = 0)]
        public static void OpenAbout() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/intro");

        [MenuItem("Tools/HybridCLR/Installer...", priority = 60)]
        private static void Open()
        {
            InstallerWindow window = EditorWindow.GetWindow<InstallerWindow>("HybridCLR Installer", true);
            window.minSize = new Vector2(800f, 500f);
        }

        [MenuItem("Tools/HybridCLR/Settings...", priority = 61)]
        public static void OpenSettings() => SettingsService.OpenProjectSettings("Project/HybridCLR Settings");

        [MenuItem("Tools/HybridCLR/Documents/Quick Start")]
        public static void OpenQuickStart() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/beginner/quickstart");

        [MenuItem("Tools/HybridCLR/Documents/Performance")]
        public static void OpenPerformance() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/basic/performance");

        [MenuItem("Tools/HybridCLR/Documents/FAQ")]
        public static void OpenFAQ() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/help/faq");

        [MenuItem("Tools/HybridCLR/Documents/Common Errors")]
        public static void OpenCommonErrors() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/help/commonerrors");

        [MenuItem("Tools/HybridCLR/Documents/Bug Report")]
        public static void OpenBugReport() => Application.OpenURL("https://hybridclr.doc.code-philosophy.com/docs/help/issue");
    }

}