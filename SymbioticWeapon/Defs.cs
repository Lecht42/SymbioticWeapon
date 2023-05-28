using RimWorld;
using System.Activities.Debugger;
using System.Activities.Expressions;
using System.Linq;
using Verse;

namespace SymbioticWeapon
{
    public class SymbiontDef : Def
    {
        public string pawnKindDefName;
        public string thingDefName;

        PawnKindDef GetPawnKindInfo() => (PawnKindDef)SimbiontWeapons.SimbiontWeapons.AllDefs.Single(def => def.defName == pawnKindDefName);
        ThingDef GetThingKindInfo() => (ThingDef)SimbiontWeapons.SimbiontWeapons.AllDefs.Single(def => def.defName == thingDefName);
    }
}
