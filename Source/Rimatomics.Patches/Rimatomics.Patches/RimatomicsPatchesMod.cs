using HarmonyLib;
using Verse;

namespace Rimatomics.Patches;

public class RimatomicsPatchesMod : Mod
{
    public RimatomicsPatchesMod(ModContentPack content) : base(content)
    {
#if DEBUG
        Logger.Warning("running in DEBUG mode!");
#endif
        new Harmony("Th3Fr3d.Rimatomics.Patches").PatchAll(typeof(RimatomicsPatchesMod).Assembly);
    }
}
