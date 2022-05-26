using BepInEx;
using HarmonyLib;

namespace Outward.SkipReadinessCheck
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class SkipReadinessCheckMod : BaseUnityPlugin
    {
        public const string GUID = "fl01.skip-readiness-check";
        public const string NAME = "Skip Readiness Check";
        public const string VERSION = "1.0.0";

        internal void Awake()
        {
            base.gameObject.AddComponent<MenuChecker>();
            new Harmony(GUID).PatchAll();
        }
    }
}
