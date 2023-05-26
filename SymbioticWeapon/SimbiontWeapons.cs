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
        static readonly ModContentPack Mod = LoadedModManager.RunningMods.Single((ModContentPack mod) => mod.Name == ModName);
        static readonly IEnumerable<Def> AllDefs = Mod.AllDefs;
        static readonly IEnumerable<SymbiotKindDef> KindSymbiontDefs = 
            AllDefs.Where(def => def is SymbiotKindDef sDef && sDef.pairId != null).Cast<SymbiotKindDef>();
        static readonly IEnumerable<SymbiotThingDef> ThingSymbiontDefs =
            AllDefs.Where(def => def is SymbiotThingDef sDef && sDef.pairId != null).Cast<SymbiotThingDef>();
        static IEnumerable<PawnSymbiont> SimbiontDefs = new PawnSymbiont[0];

        static SimbiontWeapons()
        { 
            var pairedDefs = KindSymbiontDefs.Join(
            ThingSymbiontDefs,
            kindDef => kindDef.pairId,
            thingDef => thingDef.pairId,
            (kindDef, thingDef) => {
                SimbiontDefs.AddItem(new PawnSymbiont(kindDef, thingDef));
                return string.Concat(kindDef.defName, " - ", thingDef.defName);
             });


            foreach (var def in pairedDefs) {
                Log.Message(def);
            }
        }
    }
}
