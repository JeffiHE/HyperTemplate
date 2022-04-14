using System;

namespace HyperElk.Core
{
    public class HyperTemplate : CombatRoutine
    {
        // Your class must contain at least 4 functions:
        //  - Initialize
        //  - Pulse
        //  - OutOfCombatPulse
        //  - CombatPulse

        // Executed once when the rotation is loaded (then again if the rotation is reloaded) into HyperElk.
        // This is where you will do this such as:
        //  - Add Spells that will need to be cast (CombatRoutine.AddSpell)
        //  - Add Buffs/Debuffs that need to be tracked (CombatRoutine.AddBuff/AddDebuff)
        //      - This would also include any unit auras that you may want to dispell (Enrage, Curse, ect).
        //  - Add Items that will be used (CombatRoutine.AddItem)
        //  - Add Macros that will be bound (CombatRoutine.AddMacro)
        //  - Add settings that will be displayed in the HyperElk UI for the user to modify (CombatRoutine.AddProp)
        public override void Initialize()
        {
        }

        // Executed every 100ms before CombaPulse and OutOfCombatPulse
        // This should contain anything you want to happen every pulse (and should be used sparingly), regardless of combat state.
        // This is used primarily by healers as their rotations are not really dependant on combat.
        public override void Pulse()
        {
            
        }

        // Executed after Pulse() while the player is in combat.
        public override void CombatPulse()
        {
        }

        // Executed after Pulse() while the player is NOT in combat.
        public override void OutOfCombatPulse()
        {
        }

    }
}