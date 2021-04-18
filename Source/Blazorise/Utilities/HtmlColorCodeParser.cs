﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
#endregion

namespace Blazorise.Utilities
{
    /// <summary>
    /// Utility methods for parsing of color codes.
    /// </summary>
    public static class HtmlColorCodeParser
    {
        #region Constants

        private static readonly Regex HtmlColorRegex = new( @"^#((?'R'[0-9a-f]{2})(?'G'[0-9a-f]{2})(?'B'[0-9a-f]{2}))|((?'R'[0-9a-f])(?'G'[0-9a-f])(?'B'[0-9a-f]))$", RegexOptions.Compiled | RegexOptions.IgnoreCase );

        #endregion

        #region HTML Color name to Hex-code

        private static readonly Dictionary<string, int> Mapping = new( StringComparer.OrdinalIgnoreCase )
        {
            { "AlgaeGreen", 0x64E986 },
            { "AliceBlue", 0xF0F8FF },
            { "AlienGreen", 0x6CC417 },
            { "AntiqueWhite", 0xFAEBD7 },
            { "Aquamarine", 0x7FFFD4 },
            { "ArmyBrown", 0x827B60 },
            { "AshGray", 0x666362 },
            { "AvocadoGreen", 0xB2C248 },
            { "AztechPurple", 0x893BFF },
            { "Azure", 0xF0FFFF },
            { "BabyBlue", 0x95B9C7 },
            { "BashfulPink", 0xC25283 },
            { "BasketBallOrange", 0xF88158 },
            { "BattleshipGray", 0x848482 },
            { "BeanRed", 0xF75D59 },
            { "BeeYellow", 0xE9AB17 },
            { "Beer", 0xFBB117 },
            { "BeetleGreen", 0x4C787E },
            { "Beige", 0xF5F5DC },
            { "Black", 0x000000 },
            { "BlackCat", 0x413839 },
            { "BlackCow", 0x4C4646 },
            { "BlackEel", 0x463E3F },
            { "BlanchedAlmond", 0xFFEBCD },
            { "Blonde", 0xFBF6D9 },
            { "BloodRed", 0x7E3517 },
            { "BlossomPink", 0xF9B7FF },
            { "BlueAngel", 0xB7CEEC },
            { "BlueDiamond", 0x4EE2EC },
            { "BlueDress", 0x157DEC },
            { "BlueEyes", 0x1569C7 },
            { "BlueGray", 0x98AFC7 },
            { "BlueHosta", 0x77BFC7 },
            { "BlueIvy", 0x3090C7 },
            { "BlueJay", 0x2B547E },
            { "BlueKoi", 0x659EC7 },
            { "BlueLagoon", 0x8EEBEC },
            { "BlueLotus", 0x6960EC },
            { "BlueOrchid", 0x1F45FC },
            { "BlueRibbon", 0x306EFF },
            { "BlueWhale", 0x342D7E },
            { "BlueZircon", 0x57FEFF },
            { "BlueberryBlue", 0x0041C2 },
            { "Bluegreen", 0x7BCCB5 },
            { "BlushPink", 0xE6A9EC },
            { "BlushRed", 0xE56E94 },
            { "Brass", 0xB5A642 },
            { "BrightGold", 0xFDD017 },
            { "BrightNeonPink", 0xF433FF },
            { "Bronze", 0xCD7F32 },
            { "BrownBear", 0x835C3B },
            { "BrownSugar", 0xE2A76F },
            { "BulletShell", 0xAF9B60 },
            { "Burgundy", 0x8C001A },
            { "BurlyWood", 0xDEB887 },
            { "BurntPink", 0xC12267 },
            { "ButterflyBlue", 0x38ACEC },
            { "CadillacPink", 0xE38AAE },
            { "Camelbrown", 0xC19A6B },
            { "CamouflageGreen", 0x78866B },
            { "Cantaloupe", 0xFFA62F },
            { "Caramel", 0xC68E17 },
            { "CarbonGray", 0x625D5D },
            { "CarnationPink", 0xF778A1 },
            { "Celeste", 0x50EBEC },
            { "Champagne", 0xF7E7CE },
            { "Charcoal", 0x34282C },
            { "Chartreuse", 0x8AFB17 },
            { "CherryRed", 0xC24641 },
            { "Chestnut", 0x954535 },
            { "ChestnutRed", 0xC34A2C },
            { "ChilliPepper", 0xC11B17 },
            { "Chocolate", 0xC85A17 },
            { "Cinnamon", 0xC58917 },
            { "CloudyGray", 0x6D6968 },
            { "CloverGreen", 0x3EA055 },
            { "CobaltBlue", 0x0020C2 },
            { "Coffee", 0x6F4E37 },
            { "ColumbiaBlue", 0x87AFC7 },
            { "ConstructionConeOrange", 0xF87431 },
            { "CookieBrown", 0xC7A317 },
            { "Copper", 0xB87333 },
            { "Coral", 0xFF7F50 },
            { "CoralBlue", 0xAFDCEC },
            { "CornYellow", 0xFFF380 },
            { "CornflowerBlue", 0x6495ED },
            { "Cornsilk", 0xFFF8DC },
            { "CottonCandy", 0xFCDFFF },
            { "Cranberry", 0x9F000F },
            { "Cream", 0xFFFFCC },
            { "Crimson", 0xE238EC },
            { "CrocusPurple", 0x9172EC },
            { "CrystalBlue", 0x5CB3FF },
            { "CyanOpaque", 0x92C7C7 },
            { "CyanorAqua", 0x00FFFF },
            { "DarkCarnationPink", 0xC12283 },
            { "DarkForestGreen", 0x254117 },
            { "DarkGoldenrod", 0xAF7817 },
            { "DarkOrange", 0xF88017 },
            { "DarkOrchid", 0x7D1B7E },
            { "DarkSalmon", 0xE18B6B },
            { "DarkSeaGreen", 0x8BB381 },
            { "DarkSlateBlue", 0x2B3856 },
            { "DarkSlateGrey", 0x25383C },
            { "DarkTurquoise", 0x3B9C9C },
            { "DarkViolet", 0x842DCE },
            { "DaySkyBlue", 0x82CAFF },
            { "DeepPeach", 0xFFCBA4 },
            { "DeepPink", 0xF52887 },
            { "DeepSkyBlue", 0x3BB9FF },
            { "DenimBlue", 0x79BAEC },
            { "DenimDarkBlue", 0x151B8D },
            { "DesertSand", 0xEDC9AF },
            { "DimorphothecaMagenta", 0xE3319D },
            { "DodgerBlue", 0x1589FF },
            { "DollarBillGreen", 0x85BB65 },
            { "DragonGreen", 0x6AFB92 },
            { "DullPurple", 0x7F525D },
            { "EarthBlue", 0x0000A0 },
            { "Eggplant", 0x614051 },
            { "ElectricBlue", 0x9AFEFF },
            { "EmeraldGreen", 0x5FFB17 },
            { "FallLeafBrown", 0xC8B560 },
            { "FernGreen", 0x667C26 },
            { "FerrariRed", 0xF70D1A },
            { "FireEngineRed", 0xF62817 },
            { "Firebrick", 0x800517 },
            { "FlamingoPink", 0xF9A7B0 },
            { "ForestGreen", 0x4E9258 },
            { "FrogGreen", 0x99C68E },
            { "GingerBrown", 0xC9BE62 },
            { "GlacialBlueIce", 0x368BC1 },
            { "Goldenbrown", 0xEAC117 },
            { "Goldenrod", 0xEDDA74 },
            { "Granite", 0x837E7C },
            { "Grape", 0x5E5A80 },
            { "Grapefruit", 0xDC381F },
            { "Gray", 0x736F6E },
            { "GrayCloud", 0xB6B6B4 },
            { "GrayDolphin", 0x5C5858 },
            { "GrayGoose", 0xD1D0CE },
            { "GrayWolf", 0x504A4B },
            { "GrayishTurquoise", 0x5E7D7E },
            { "Green", 0x00FF00 },
            { "GreenApple", 0x4CC417 },
            { "GreenOnion", 0x6AA121 },
            { "GreenPeas", 0x89C35C },
            { "GreenSnake", 0x6CBB3C },
            { "GreenThumb", 0xB5EAAA },
            { "GreenYellow", 0xB1FB17 },
            { "GreenishBlue", 0x307D7E },
            { "Gunmetal", 0x2C3539 },
            { "HalloweenOrange", 0xE66C2C },
            { "HarvestGold", 0xEDE275 },
            { "HazelGreen", 0x617C58 },
            { "HeliotropePurple", 0xD462FF },
            { "HotPink", 0xF660AB },
            { "HummingbirdGreen", 0x7FE817 },
            { "Iceberg", 0x56A5EC },
            { "IguanaGreen", 0x9CB071 },
            { "Indigo", 0x4B0082 },
            { "Iridium", 0x3D3C3A },
            { "JadeGreen", 0x5EFB6E },
            { "JasminePurple", 0xA23BEC },
            { "JeansBlue", 0xA0CFEC },
            { "Jellyfish", 0x46C7C7 },
            { "JetGray", 0x616D7E },
            { "JungleGreen", 0x347C2C },
            { "KellyGreen", 0x4CC552 },
            { "Khaki", 0xADA96E },
            { "KhakiRose", 0xC5908E },
            { "LapisBlue", 0x15317E },
            { "LavaRed", 0xE42217 },
            { "LavenderPinocchio", 0xEBDDE2 },
            { "Lavenderblue", 0xE3E4FA },
            { "LawnGreen", 0x87F717 },
            { "LemonChiffon", 0xFFF8C6 },
            { "LightAquamarine", 0x93FFE8 },
            { "LightBlue", 0xADDFFF },
            { "LightCoral", 0xE77471 },
            { "LightCyan", 0xE0FFFF },
            { "LightJade", 0xC3FDB8 },
            { "LightPink", 0xFAAFBA },
            { "LightSalmon", 0xF9966B },
            { "LightSeaGreen", 0x3EA99F },
            { "LightSkyBlue", 0x82CAFA },
            { "LightSlate", 0xCCFFFF },
            { "LightSlateBlue", 0x736AFF },
            { "LightSlateGray", 0x6D7B8D },
            { "LightSteelBlue", 0x728FCE },
            { "Lilac", 0xC8A2C8 },
            { "LimeGreen", 0x41A317 },
            { "LipstickPink", 0xC48793 },
            { "LoveRed", 0xE41B17 },
            { "LovelyPurple", 0x7F38EC },
            { "MacaroniandCheese", 0xF2BB66 },
            { "MacawBlueGreen", 0x43BFC7 },
            { "Magenta", 0xFF00FF },
            { "Mahogany", 0xC04000 },
            { "MangoOrange", 0xFF8040 },
            { "MarbleBlue", 0x566D7E },
            { "Maroon", 0x810541 },
            { "Mauve", 0xE0B0FF },
            { "MediumAquamarine", 0x348781 },
            { "MediumForestGreen", 0x347235 },
            { "MediumOrchid", 0xB048B5 },
            { "MediumPurple", 0x8467D7 },
            { "MediumSeaGreen", 0x306754 },
            { "MediumSpringGreen", 0x348017 },
            { "MediumTurquoise", 0x48CCCD },
            { "MediumVioletRed", 0xCA226B },
            { "MetallicSilver", 0xBCC6CC },
            { "Midnight", 0x2B1B17 },
            { "MidnightBlue", 0x151B54 },
            { "MilkWhite", 0xFEFCFF },
            { "Mintgreen", 0x98FF98 },
            { "MistBlue", 0x646D7E },
            { "MistyRose", 0xFBBBB9 },
            { "Moccasin", 0x827839 },
            { "Mocha", 0x493D26 },
            { "Mustard", 0xFFDB58 },
            { "NavyBlue", 0x000080 },
            { "NebulaGreen", 0x59E817 },
            { "NeonPink", 0xF535AA },
            { "Night", 0x0C090A },
            { "NorthernLightsBlue", 0x78C7C7 },
            { "OakBrown", 0x806517 },
            { "OceanBlue", 0x2B65EC },
            { "Oil", 0x3B3131 },
            { "OrangeGold", 0xD4A017 },
            { "OrangeSalmon", 0xC47451 },
            { "PaleBlueLily", 0xCFECEC },
            { "PaleVioletRed", 0xD16587 },
            { "PapayaOrange", 0xE56717 },
            { "Parchment", 0xFFFFC2 },
            { "PastelBlue", 0xB4CFEC },
            { "Peach", 0xFFE5B4 },
            { "Pearl", 0xFDEEF4 },
            { "Periwinkle", 0xE9CFEC },
            { "PigPink", 0xFDD7E4 },
            { "PineGreen", 0x387C44 },
            { "Pink", 0xFAAFBE },
            { "PinkBow", 0xC48189 },
            { "PinkBubbleGum", 0xFFDFDD },
            { "PinkCupcake", 0xE45E9D },
            { "PinkDaisy", 0xE799A3 },
            { "PinkLemonade", 0xE4287C },
            { "PinkRose", 0xE7A1B0 },
            { "PistachioGreen", 0x9DC209 },
            { "Platinum", 0xE5E4E2 },
            { "Plum", 0xB93B8F },
            { "PlumPie", 0x7D0541 },
            { "PlumPurple", 0x583759 },
            { "PlumVelvet", 0x7D0552 },
            { "PowderBlue", 0xC6DEFF },
            { "Puce", 0x7F5A58 },
            { "PumpkinOrange", 0xF87217 },
            { "Purple", 0x8E35EF },
            { "PurpleAmethyst", 0x6C2DC7 },
            { "PurpleDaffodil", 0xB041FF },
            { "PurpleDragon", 0xC38EC7 },
            { "PurpleFlower", 0xA74AC7 },
            { "PurpleHaze", 0x4E387E },
            { "PurpleIris", 0x571B7E },
            { "PurpleJam", 0x6A287E },
            { "PurpleMimosa", 0x9E7BFF },
            { "PurpleMonster", 0x461B7E },
            { "PurpleSageBush", 0x7A5DC7 },
            { "Red", 0xFF0000 },
            { "RedDirt", 0x7F5217 },
            { "RedFox", 0xC35817 },
            { "RedWine", 0x990012 },
            { "RobinEggBlue", 0xBDEDFF },
            { "RoguePink", 0xC12869 },
            { "Rose", 0xE8ADAA },
            { "RoseGold", 0xECC5C0 },
            { "RosyBrown", 0xB38481 },
            { "RosyFinch", 0x7F4E52 },
            { "RoyalBlue", 0x2B60DE },
            { "RubberDuckyYellow", 0xFFD801 },
            { "RubyRed", 0xF62217 },
            { "Rust", 0xC36241 },
            { "Saffron", 0xFBB917 },
            { "SageGreen", 0x848b79 },
            { "SaladGreen", 0xA1C935 },
            { "Sand", 0xC2B280 },
            { "Sandstone", 0x786D5F },
            { "SandyBrown", 0xEE9A4D },
            { "Sangria", 0x7E3817 },
            { "SapphireBlue", 0x2554C7 },
            { "Scarlet", 0xFF2400 },
            { "SchoolBusYellow", 0xE8A317 },
            { "SeaBlue", 0xC2DFFF },
            { "SeaGreen", 0x4E8975 },
            { "SeaShell", 0xFFF5EE },
            { "SeaTurtleGreen", 0x438D80 },
            { "SeaweedGreen", 0x437C17 },
            { "Sedona", 0xCC6600 },
            { "Sepia", 0x7F462C },
            { "ShamrockGreen", 0x347C17 },
            { "ShockingOrange", 0xE55B3C },
            { "Sienna", 0x8A4117 },
            { "SilkBlue", 0x488AC7 },
            { "SkyBlue", 0x6698FF },
            { "SlateBlue", 0x737CA1 },
            { "SlateGray", 0x657383 },
            { "SlimeGreen", 0xBCE954 },
            { "SmokeyGray", 0x726E6D },
            { "SpringGreen", 0x4AA02C },
            { "SteelBlue", 0x4863A0 },
            { "StoplightGoGreen", 0x57E964 },
            { "SunYellow", 0xFFE87C },
            { "SunriseOrange", 0xE67451 },
            { "TanBrown", 0xECE5B6 },
            { "Tangerine", 0xE78A61 },
            { "Taupe", 0x483C32 },
            { "TeaGreen", 0xCCFB5D },
            { "Teal", 0x008080 },
            { "Thistle", 0xD2B9D3 },
            { "TiffanyBlue", 0x81D8D0 },
            { "TigerOrange", 0xC88141 },
            { "TronBlue", 0x7DFDFE },
            { "TulipPink", 0xC25A7C },
            { "Turquoise", 0x43C6DB },
            { "TyrianPurple", 0xC45AEC },
            { "ValentineRed", 0xE55451 },
            { "VampireGray", 0x565051 },
            { "Vanilla", 0xF3E5AB },
            { "VelvetMaroon", 0x7E354D },
            { "VenomGreen", 0x728C00 },
            { "ViolaPurple", 0x7E587E },
            { "Violet", 0x8D38C9 },
            { "VioletRed", 0xF6358A },
            { "Water", 0xEBF4FA },
            { "WatermelonPink", 0xFC6C85 },
            { "White", 0xFFFFFF },
            { "WindowsBlue", 0x357EC7 },
            { "WisteriaPurple", 0xC6AEC7 },
            { "Wood", 0x966F33 },
            { "Yellow", 0xFFFF00 },
            { "YellowGreen", 0x52D017 },
            { "ZombieGreen", 0x54C571 }
        };

        #endregion

        #region Methods

        /// <summary>
        /// Parses the supplied HTML color code. This can be defined in short ot long hexadecimal form, or as text.
        /// </summary>
        /// <param name="code">The code to parse</param>
        /// <param name="red">The red value</param>
        /// <param name="green">The green value</param>
        /// <param name="blue">The blue value </param>
        /// <returns><see langword="true"/> if the <paramref name="code"/> is parsed successfully, else <see langword="false"/></returns>
        public static bool TryParse( string code, out byte red, out byte green, out byte blue )
        {
            red = 0;
            green = 0;
            blue = 0;

            if ( string.IsNullOrWhiteSpace( code ) )
            {
                return false;
            }

            var match = HtmlColorRegex.Match( code );

            if ( match.Success )
            {
                red = ParseHexValueAsByte( match.Groups["R"].Value );
                green = ParseHexValueAsByte( match.Groups["G"].Value );
                blue = ParseHexValueAsByte( match.Groups["B"].Value );

                return true;
            }

            if ( Mapping.TryGetValue( code, out var hexCode ) )
            {
                red = (byte)( ( hexCode & 0xFF0000 ) >> 16 );
                green = (byte)( ( hexCode & 0x00FF00 ) >> 8 );
                blue = (byte)( hexCode & 0x0000FF );

                return true;
            }

            return false;
        }

        private static byte ParseHexValueAsByte( string value )
        {
            return byte.Parse( value, NumberStyles.AllowHexSpecifier );
        }

        #endregion
    }
}