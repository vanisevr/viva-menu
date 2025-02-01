﻿using iiMenu.Menu;
using iiMenu.Notifications;
using System.IO;
using static iiMenu.Menu.Main;

namespace iiMenu.Mods
{
    public class Presets
    {
        public static void LegitimatePreset()
        {
            string[] presetMods = new string[]
            {
                "Joystick Menu",
                "Thin Menu",
                "Disable Enabled GUI",
                "Disable Board Colors",
                "Disable Disconnect Button",
                "Disable Page Buttons",
                "Disable Search Button",
                "Disable Return Button",
                "Hidden on Camera",
                "Hide Notifications on Camera",
                "Hide Text on Camera",
                "Disable FPS Counter",
                "Fix Rig Colors",
            };

            themeType = 29;
            pageButtonType = 1;
            fontCycle = -1;

            Settings.ChangeMenuTheme();
            Settings.ChangePageType();
            Settings.ChangeFontType();

            Settings.Panic();
            foreach (string mod in presetMods)
            {
                Main.Toggle(mod);
            }
            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("<color=grey>[</color><color=purple>PRESET</color><color=grey>]</color> Legitimate preset enabled successfully.");
        }

        public static void GhostPreset()
        {
            string[] presetMods = new string[]
            {
                "Ghost <color=grey>[</color><color=green>A</color><color=grey>]</color>",
                "Invisible <color=grey>[</color><color=green>B</color><color=grey>]</color>",
                "Noclip <color=grey>[</color><color=green>T</color><color=grey>]</color>",
                "Steam Long Arms",
                "Break Audio Gun",
                "No Finger Movement",
                "Platforms"
            };

            longarmCycle = 3;
            armlength = 1.5f;
            
            Settings.Panic();
            foreach (string mod in presetMods)
            {
                Main.Toggle(mod);
            }
            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("<color=grey>[</color><color=purple>PRESET</color><color=grey>]</color> Ghost preset enabled successfully.");
        }

        public static void SaveCustomPreset(int id)
        {
            if (!Directory.Exists("iisStupidMenu"))
            {
                Directory.CreateDirectory("iisStupidMenu");
            }
            if (!Directory.Exists("iisStupidMenu/SavedPresets"))
            {
                Directory.CreateDirectory("iisStupidMenu/SavedPresets");
            }
            File.WriteAllText("iisStupidMenu/SavedPresets/Preset_" + id.ToString() + ".txt", Settings.SavePreferencesToText());
        }

        public static void LoadCustomPreset(int id)
        {
            if (Directory.Exists("iisStupidMenu"))
            {
                if (Directory.Exists("iisStupidMenu/SavedPresets"))
                {
                    string text = File.ReadAllText("iisStupidMenu/SavedPresets/Preset_" + id.ToString() + ".txt");
                    UnityEngine.Debug.Log(text);
                    Settings.LoadPreferencesFromText(text);
                }
            }
        }

        public static void GoldentrophyPreset()
        {
            string[] presetMods = new string[]
            {
                "Inner Outline Menu",
                "Outline Menu",
                "Freeze Player in Menu",
                "Clear Notifications on Disconnect",
                "Disable Enabled GUI",
                "Legacy Ghostview",
                "Finger Gun Projectiles",
                "Rainbow Projectiles",
                "Force Enable Hands",
                "Anti AFK",
                "Physical Quit Box",
                "Tag Lag Detector",
                "Day Time",
                "Clear Weather",
                "Info Watch",
                "Fix Rig Colors",
                "Cosmetic ESP",
                "Infection Tracers",
                "Infection Distance ESP",
                "Auto Party Kick",
                "Obnoxious Tag"
            };

            themeType = 33;
            pageButtonType = 1;
            fontCycle = -1;

            Settings.ChangeMenuTheme();
            Settings.ChangePageType();
            Settings.ChangeFontType();

            Settings.Panic();
            foreach (string mod in presetMods)
            {
                Main.Toggle(mod);
            }
            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("<color=grey>[</color><color=purple>PRESET</color><color=grey>]</color> Goldentrophy preset enabled successfully.");
        }

        public static void PerformancePreset()
        {
            string[] presetMods = new string[]
            {
                "Disable Enabled GUI",
                "Disable Board Colors",
                "Disable FPS Counter",
                "FPS Boost",
                "Disable Ghostview"
            };

            themeType = 31;
            pageButtonType = 1;
            fontCycle = 0;

            Settings.ChangeMenuTheme();
            Settings.ChangePageType();
            Settings.ChangeFontType();

            Settings.Panic();
            foreach (string mod in presetMods)
            {
                Main.Toggle(mod);
            }

            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("<color=grey>[</color><color=purple>PRESET</color><color=grey>]</color> Performance preset enabled successfully.");
        }

        public static void SafetyPreset()
        {
            string[] presetMods = new string[]
            {
                "No Finger Movement",
                "Fake Oculus Menu <color=grey>[</color><color=green>X</color><color=grey>]</color>",
                "Disable Gamemode Buttons",
                "Anti Crash",
                "Anti Moderator",
                "Anti Report <color=grey>[</color><color=green>Disconnect</color><color=grey>]</color>",
                "Show Anti Cheat Reports <color=grey>[</color><color=green>Self</color><color=grey>]</color>"
            };

            themeType = 34;
            pageButtonType = 1;
            fontCycle = 0;

            Settings.ChangeMenuTheme();
            Settings.ChangePageType();
            Settings.ChangeFontType();

            Settings.Panic();
            foreach (string mod in presetMods)
            {
                Main.Toggle(mod);
            }

            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("<color=grey>[</color><color=purple>PRESET</color><color=grey>]</color> Safety preset enabled successfully.");
        }
    }
}
