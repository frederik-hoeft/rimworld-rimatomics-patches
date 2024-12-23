using HarmonyLib;
using Verse;

namespace Rimatomics.Patches.HarmonyPatches;

[HarmonyPatch(typeof(PlaceWorker_WaterStation), nameof(PlaceWorker_WaterStation.IsWatah))]
public static class Patch_PlaceWorker_WaterStation_IsWatah
{
    internal static void Postfix(ref bool __result, IntVec3 intVec)
    {
        if (!__result)
        {
            Map map = Find.CurrentMap;
            int index = map.cellIndices.CellToIndex(intVec);
            TerrainGrid grid = map.terrainGrid;
            __result = grid.topGrid[index] is { Removable: true, bridge: true } 
                && grid.UnderTerrainAt(index) is { edgeType: TerrainDef.TerrainEdgeType.Water };
        }
    }
}
