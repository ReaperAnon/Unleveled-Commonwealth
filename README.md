![New Project2](https://github.com/ReaperAnon/Unleveled-Commonwealth/assets/63963239/09265719-5be4-437a-9c80-c16186abcc1d)

### [Synthesis Install](https://github.com/Mutagen-Modding/Synthesis/wiki/Installation)
### [How to Use](https://github.com/Mutagen-Modding/Synthesis/wiki/Typical-Usage#adding-patchers)

### [Support Discord](https://discord.gg/5FaCGrFYM3)

The mod can be found either by searching for UnleveledFallout on the patcher list or added via the .synth file found [here](https://github.com/ReaperAnon/Unleveled-Commonwealth/releases/tag/meta).

### Consider donating if you enjoy my work:
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/A0A6P3CRK)

# Details
A dynamically generated mod which unlevels all NPCs and creatures and changes health scaling to completely eliminate stat bloat from the game. Compatible with every mod without needing patches (just a new entry in the patcher's settings if they use a custom race). 

The patcher will make all NPCs that scale with the player a set level (depending on what their minimum and maximum levels were) and standardizes their stats, eliminating all health scaling from the game.

Unlike SCOURGE, the patcher has the ability to compare NPCs to each other which is not possible in-game, keeping the relative balance of all enemies the same as it was in vanilla instead of stats being random. Stronger variants will always be stronger, but within the confines of the new health ranges.

## Pros Compared To SCOURGE
SCOURGE is a good mod in combination with the Scaling Flag Remover, but there are definite downsides to changing enemy stats during run-time, like having to randomize them.

The pros this mod offers are as follows:
- More compatibility, because it includes a general section that works on every NPC type that isn't covered by default.
- Easier compatibility patching, as you can easily add new races from mods to existing categories without having to understand how the mod actually works.
- Enemy stats aren't randomized. The original health values are used as a scale for the new values, meaning that the enemies which used to be the toughest in the vanilla game (like a Gunner Captain which had over 1000 health) will still be the toughest human enemy, but (with the default settings) will have a health value of around 120 from the possible range of 80-120. Same with the Concord raiders who used to have around 20-30 health, being some of the weakest in the game, who will now have a health value of around 80. 
- No additional mods like the Scaling Flag Remover are needed, as all actors are given a static level by this mod along with fitting stats for that level.
- Level-based health scaling is completely eliminated both for the player and enemies by default, without having to worry about compatibility.

## Cons Compared To SCOURGE
This mod changes the actual plugin data and it seems like Fallout 4 bakes all the actor information into the save data when a new game is started.

This means that a **new game is required** for changes to take effect. This is also true if you make changes to the settings and regenerate the mod.

## Known Issues
The user settings menu is very slow when initially loading and when opening the Race Entries submenu. Just be patient and it'll open fine, Synthesis did not crash.

I can't really do much about it except turning it into a standalone application, which would eliminate the convenience of using it with Synthesis, making it all kind of pointless.

## Compatibility
By default the patcher has support for the following mods without any alterations:

- CW Robots
- CW Super Mutants and Nightkin
- CW Molerats
- CW Yao Guai
- CW Behemoths
- CW Radscorpions
- CW Centaurs
- CW Brahmin
- Point Lookout
- Feral Ghoul Expansion Pack (FGEP)

## Suggested Mods
- **[CALIBER Damage Overhaul](https://github.com/ReaperAnon/CALIBER-Damage-Overhaul):** Without a mod to rebalance damage values, the balance will be all over the place. I recommend using my CALIBER mod which is another Synthesis patcher that rebalances weapons to deal damage based on the ammunition they use and some other things. The damage values CALIBER uses are the ones Unleveled Commonwealth was balanced around.

- **[Armor Penetration Fix](https://www.nexusmods.com/fallout4/mods/73849):** By default the ammo penetration effect is broken in Fallout 4, so it's suggested you download this. Many NPCs have a substantial amount of armor by default (especially robots), so it's recommended to have a proper way of dealing with it.

## Credits

### Mutagen
