using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WeBall.Core.Systems;

namespace WeBall.Content.SuperHardmode.Biomes.SunPlains
{
public class SunPlainsBiome : ModBiome
{
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
    
    public override string BackgroundPath => "WeBall/Assets/Backgrounds/SunPlainsBG";
    public override string MapBackground => BackgroundPath;

    public override int Music => MusicLoader.GetMusicSlot(Mod, "Aeets/Music/SunPlainsTheme");

    public override bool IsBiomeActive(Player player)
        => SuperHardmodeSystem.superHardmode && 
           player.ZoneOverworldHeight &&
           player.ZoneForest;
}
}