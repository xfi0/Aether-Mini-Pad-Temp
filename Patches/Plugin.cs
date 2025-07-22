
using System.ComponentModel;

namespace StupidTemplate.Patches
{
    public class HarmonyPatches
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
