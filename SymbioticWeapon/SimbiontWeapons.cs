using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using Verse;
using SymbioticWeapon;

namespace SimbiontWeapons
{
    [StaticConstructorOnStartup]
    public static class SimbiontWeapons
    {
        static readonly string ModName = "SimbiontWeapons";
        static public readonly IEnumerable<Def> AllDefs = LoadedModManager.RunningMods.Single((ModContentPack mod) => mod.Name == ModName).AllDefs;
        static readonly IEnumerable<SymbiontDef> SimbiontDefs = AllDefs.Where(def => def is SymbiontDef).Cast<SymbiontDef>();

        static SimbiontWeapons()
        {

        }
    }
}
