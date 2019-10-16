﻿using Kbg.NppPluginNET.PluginInfrastructure;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Kbg.NppPluginNET.ExceptionFormatter
{
    class Main
    {
        internal const string PluginName = "SL Exception Formatter";

        public static void OnNotification(ScNotification notification)
        { 
        }

        internal static void CommandMenuInit()
        {
            PluginBase.SetCommand(0, "&Format Exception", FormatException, new ShortcutKey(true, true, true, Keys.E));
            PluginBase.SetCommand(1, "&About", About, new ShortcutKey(false, false, false, Keys.None));
        }

        internal static void FormatException()
        {
            new ExceptionFormatHandler(new ScintillaGateway(PluginBase.GetCurrentScintilla())).Format();
        }

        internal static void About()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Version 1.0");
            sb.AppendLine("License: MIT License");
            string title = "SL Exception Formatter plugin";
            MessageBox.Show(sb.ToString(), title, MessageBoxButtons.OK);
        }

        internal static void SetToolBarIcon()
        {
        }

        internal static void PluginCleanUp()
        {
        }
    }
}