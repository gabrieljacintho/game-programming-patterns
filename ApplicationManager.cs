// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using UnityEngine;

namespace Patterns
{
    public static class ApplicationManager
    {
        public static bool IsQuitting { get; private set; }


        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        private static void Initialize()
        {
            Application.quitting += OnQuitting;
        }
        
        private static void OnQuitting()
        {
            IsQuitting = true;
        }
    }
}