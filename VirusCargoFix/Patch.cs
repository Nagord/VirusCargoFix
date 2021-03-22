using HarmonyLib;

namespace VirusCargoFix
{
    [HarmonyPatch(typeof(PLShipInfoBase), "SetupShipStats")]
    class Patch
    {
        static void Postfix(PLShipInfoBase __instance)
        {
            __instance.MyStats.SetGlobalSlotLimit(ESlotType.E_COMP_VIRUS, 64);
            __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_VIRUS, 64);
        }
    }
}
