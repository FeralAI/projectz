# CHANGELOG

## VERSIONS

### v1.1.0-DC (WIP)

#### Gameplay Enhancements

* Adjustable walk speed from 1x to 3x, in 0.25x increments - [@FeralAI](https://github.com/FeralAI)
* Option to disable annoying dialogs when picking up a Piece of Power, Guardian Acorn, or other heavy items (inspired by the [Redux patch](https://www.romhacking.net/hacks/4672/)) - [@FeralAI](https://github.com/FeralAI)
* Option to swap between the default XInput control layout and Nintendo style (confirm/cancel buttons also swapped) - [@FeralAI](https://github.com/FeralAI)

#### Visual Enhancements

* Added font selection menu to make the unused monospace font from the original release available as an option - [@FeralAI](https://github.com/FeralAI)
* Adjustable shadow opacity - setting to 0% disables shadows completely for better performance via emulation - [@FeralAI](https://github.com/FeralAI)

#### Bug Fixes

* Link not able to use weapons while shield is held (only affected certain button assignments for weapons/shield) - [@FeralAI](https://github.com/FeralAI)
* Link not able to grab an object while walking into it (required letting go of directional input to activate before) - [@FeralAI](https://github.com/FeralAI)
* Link not able to drop a bomb while against a wall - [@FeralAI](https://github.com/FeralAI)
* Link not able to pick up Fairies with a weapon attack - [@FeralAI](https://github.com/FeralAI)

### v1.0.2 (a.k.a. Redux patch)

This is a version that I found in a few forms across a few repositories which already had some of the changes from [v1.0.1](#v101-unreleased). The full history of these changes is a little unclear.
If you contributed any changes in this version please create an issue or submit a pull request with an update.

#### Enhancements

* Allow screen scale adjustment via controls - [@malmazuke](https://github.com/malmazuke)
* Add quit button to title menu - [@dekart811](https://github.com/dekart811)

#### Bug Fixes

* Allow Link to block with shield while charging an attack
* Fixed Mask Mimic (Shy Guy) swapping direction when Link direction is locked, for example during a sword charge
* Fixed Pols Voice not dying to the Ocarina
* Fixed Dungeon 6 door requirements
* Fixed Piece of Power and Guardian Acorn not picking up with weapon contact

> NOTE: Not included are several asset updates that brought more color variation to the game. These are not required to run, but are easy to find with a little digging.

### v1.0.1 (unreleased)

These are changes up to commit [7848c95
](https://github.com/ladxhd/projectz/commit/7848c9570b089fd01fa06d812b996f4e32f87ec6) from [dev branch](https://github.com/ladxhd/projectz/tree/dev) of the [main projectz](https://github.com/ladxhd/projectz) repo, the staring point for this fork.

#### Enhancements

* [Hero Mode](https://zelda.fandom.com/wiki/Hero_Mode) options - [@squiddingme](https://github.com/squiddingme):
	* Adjustable enemy damage multiplier
	* Disable heart drops
* Option to move item slot UI to the right side of the screen - [@squiddingme](https://github.com/squiddingme)
* Enable small key counter in HUD - [@squiddingme](https://github.com/squiddingme)
* Enabled UI scaling control (was in the original code but unused) - [@squiddingme](https://github.com/squiddingme)

#### Bug Fixes

* Fixed soft lock when collecting instruments after clearing a dungeon - [@gatordile2](https://github.com/gatordile2)
* Fixed Armos Knight not responding to damage correctly - [@gatordile2](https://github.com/gatordile2)
* Fixed Ganon not taking damage from spin attack - [@gatordile2](https://github.com/gatordile2)
* Face Shrine using wrong key - [@gatordile2](https://github.com/gatordile2)
* Fixed inventory select sound - [@squiddingme](https://github.com/squiddingme)
* Tweaked fog opacity in Mysterious Woods - @buttcheeks69
* Sword attack speed limit - @buttcheeks69
* Fix Alligator toss animation - @buttcheeks69
* Fix saved controls not loading on startup - [@squiddingme](https://github.com/squiddingme)
* Various UI and audio fixes - [@squiddingme](https://github.com/squiddingme), @buttcheeks69

#### Project Updates

* Updated game engine to MonoGame 3.8.1.303
* Dependencies are managed via NuGet packages instead of local references

### v1.0.0

[Initial itch.io release](https://linksawakeningdxhd.itch.io/links-awakening-dx-hd) by [linksawakeningdxhd](https://itch.io/profile/linksawakeningdxhd)

## External Resources

* Updated sprite and image assets - [@gex581990](https://github.com/gex581990)
* Photo sheet - <https://www.deviantart.com/drestrada/art/Link-s-Awakening-Photo-Recolor-235878494>

## Related Issues

Several of the bugs reported on the [itch.io LADXHD community board](https://linksawakeningdxhd.itch.io/links-awakening-dx-hd/community) have been addressed:

* [Softlock while picking up instruments #3](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/3)
* [Armos Knight has wrong weakness #5](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/5)
* [Sword can't be swung until previous swing animation is finished. #8](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/8)
* [Can't pick things up using power bracelet with direction button pressed. #10](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/10)
* [Shy Guys do not properly mimic Link's movement with sword drawn #21](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/21)
* [Cannot swing sword while holding shield out #22](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/22)
* [The Piece of Power item cannot be retrieved using the sword #23](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/23)
* [Playing the Ocarina does not kill Pols Voice #29](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues/29)

## Open Issues

* [Old Github Issues](https://github.com/ihm-tswow/Links-Awakening-DX-HD/issues)
* [Color Dungeon bosses are bugged](https://itch.io/t/3983650/color-dungeon-bosses-are-bugged)
* [Game breaking bug - Level 8 Turtle Rock](https://itch.io/t/3371191/game-breaking-bug-level-8-turtle-rock) (may be fixed)
* [Close, but a few differences](https://itch.io/t/3360037/close-but-a-few-differences)
* [Bugs](https://itch.io/t/3357767/bugs)