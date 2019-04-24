using Verse;

namespace MURWallLight {

    // Secondary colors

    public class WallLightYellow : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerYellow";
            this.moteStr = "Lighting_MURWallLightYellowVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightMagenta : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerMagenta";
            this.moteStr = "Lighting_MURWallLightMagentaVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightCyan : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerCyan";
            this.moteStr = "Lighting_MURWallLightCyanVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    // Tertiary colors

    public class WallLightRose : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerRose";
            this.moteStr = "Lighting_MURWallLightRoseVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightViolet : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerViolet";
            this.moteStr = "Lighting_MURWallLightVioletVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightAzure : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerAzure";
            this.moteStr = "Lighting_MURWallLightAzureVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightSpringGreen : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerSpringGreen";
            this.moteStr = "Lighting_MURWallLightSpringGreenVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightChartreuse : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerChartreuse";
            this.moteStr = "Lighting_MURWallLightChartreuseVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

    public class WallLightOrange : WallLight {
        public override void ColorSetup() {
            this.defStr = "Lighting_MURWallLightVII_GlowerOrange";
            this.moteStr = "Lighting_MURWallLightOrangeVII_On";
            this.onDef = ThingDef.Named(this.moteStr);
        }
    }

}
