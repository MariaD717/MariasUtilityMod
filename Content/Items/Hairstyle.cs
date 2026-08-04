using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MariasUtilityMod.Content.Items
{
    public class Hairstyle : ModHair
    {
        public override Gender RandomizedCharacterCreationGender => Gender.Female;

        public override bool AvailableDuringCharacterCreation => true;

        public override void SetStaticDefaults() {
            HairID.Sets.DrawBackHair[Type] = true;
        }
    }

    
       
}
