namespace SymbioticWeapon
{
    public class PawnSymbiont 
    {
        SymbiotKindDef KindDef;
        SymbiotThingDef ThingDef;

        public PawnSymbiont(SymbiotKindDef kindDef, SymbiotThingDef thingDef) {
            KindDef = kindDef;
            ThingDef = thingDef;
        }
    }
}
