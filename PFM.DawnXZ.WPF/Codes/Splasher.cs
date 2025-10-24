using System;
using System.Windows;
namespace PFM.DawnXZ.WPF.Codes
{
    /// Helper to show or close given splash window
    public static class Splasher
    {
        /// Get or set the splash screen window
        public static Window Splash { get; set; }
        /// Show splash screen
        public static void ShowSplash()
        {
            if (Splash != null) Splash.Dispatcher.BeginInvoke(new Action(() => { Splash.Show(); }));
        }
        /// Hide splash screen
        public static void HideSplash()
        {
            if (Splash != null) Splash.Dispatcher.BeginInvoke(new Action(() => { Splash.Hide(); }));
        }
        /// Close splash screen
        public static void CloseSplash()
        {
            if (Splash != null)
            {
                Splash.Dispatcher.BeginInvoke(new Action(() => { Splash.Close(); }));
                Splash.Dispatcher.BeginInvoke(new Action(() => { if (Splash is IDisposable) (Splash as IDisposable).Dispose(); }));
            }
        }
    }
}
