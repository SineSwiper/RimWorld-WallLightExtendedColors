using System.Collections.Generic;

using MURWallLight;

using HarmonyLib;
using RimWorld;
using Verse;

namespace MURWallLight {

    // Secondary colors

    public class WallLightYellow : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightYellow");
        }
    }

    public class WallLightMagenta : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightMagenta");
        }
    }

    public class WallLightCyan : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightCyan");
        }
    }

    // Tertiary colors

    public class WallLightRose : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightRose");
        }
    }

    public class WallLightViolet : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightViolet");
        }
    }

    public class WallLightAzure : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightAzure");
        }
    }

    public class WallLightSpringGreen : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightSpringGreen");
        }
    }

    public class WallLightChartreuse : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightChartreuse");
        }
    }

    public class WallLightOrange : WallLight {
        public override void SetReplacement() {
            replacementDef = ThingDef.Named("Lighting_MURWallLightOrange");
        }
    }
}

namespace WallLightExtendedColors {
    [StaticConstructorOnStartup]
    public static class Resources {
        public static List<string> extendedColorList = new List<string> {
            "Yellow",
            "Magenta",
            "Cyan",
            "Rose",
            "Violet",
            "Azure",
            "SpringGreen",
            "Chartreuse",
            "Orange"
        };

        static Resources() {
            Dictionary<int, Graphic> graphics = CompGlowerOffset.Resources.graphics;
            int i = 5;
            foreach (string color in extendedColorList) {
                graphics[i] = GraphicDatabase.Get<Graphic_Multi>("Things/Building/MURWallLight" + color);
                i++;
            }
        }
    }
    
    [StaticConstructorOnStartup]
    public class HarmonyPatches {
        static HarmonyPatches() {
            new Harmony("SineSwiper.WallLightExtendedColors").PatchAll();
        }

        // Make ChangeDefs also affect our lights
        [HarmonyPatch(typeof(WallLightSettings), "ChangeDefs")]
        private static class ChangeDefsPatch {
            [HarmonyPostfix]
            static void Postfix() {
                foreach (string color in Resources.extendedColorList) {
                    ThingDef lightDef  = ThingDef.Named("Lighting_MURWallLight"        + color);
                    ThingDef glowerDef = ThingDef.Named("Lighting_MURWallLight_Glower" + color);

                    lightDef .GetCompProperties<CompProperties_Power >().basePowerConsumption = WallLightSettings.powerCost;
                    glowerDef.GetCompProperties<CompProperties_Glower>().glowRadius           = WallLightSettings.glowRad;
                    
                    lightDef.costList[0].count = WallLightSettings.steelCost;
                }
            }
        }

    }

}
