using HarmonyLib;
using viva.Notifications;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static iiMenu.Menu.Main;

namespace viva.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    public class JoinPatch
    {
        private static void Prefix(Player newPlayer)
        {
            if (newPlayer != oldnewplayer)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>JOIN</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
                if (customSoundOnJoin)
                {
                    if (!Directory.Exists("viva-menu"))
                    {
                        Directory.CreateDirectory("viva-menu");
                    }
                    File.WriteAllText("iisStupidMenu/iiMenu_CustomSoundOnJoin.txt", "PlayerJoin");
                }
                oldnewplayer = newPlayer;
            }
        }

        private static Player oldnewplayer;
    }
}
