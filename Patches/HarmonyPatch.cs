using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
    public class Menu
    {
        public static bool IsPatched { get; private set; }

        internal static void ApplyHarmonyPatches()
        {
            if (!IsPatched)
            {
                if (instance == null)
                {
                    instance = new HarmonyLib.Harmony(StupidTemplate.PluginInfo.GUID);
                }
                instance.PatchAll();
                IsPatched = true;
            }
        }

        internal static void RemoveHarmonyPatches()
        {
            if (instance != null && IsPatched)
            {
                IsPatched = false;
            }
        }

        private static HarmonyLib.Harmony instance;
    }
}
