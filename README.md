# Link's Awakening DX HD - Developer's Cut

This is the source code for ProjectZ, a fan-made PC port of the Game Boy Color game **The Legend of Zelda, Link's Awakening DX**.

*Only* the source code is present — any copyrighted assets (sprite sheets, sound effects etc.) must be provided by the user.


## Requirements

### Development

* .NET 6 SDK
* The original source archive, which includes all binary assets used by the game (sprite sheets, sound effects, music in Game Boy Sound format) and the English language script. `source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`

Visual Studio 2022 is recommended for development, but not required to build or publish the project.

### Running The Game

The only requirement the .NET 6 Runtime. The SDK includes the runtime, so if you built from source you're good to go!

## Build Instructions

1. Clone this repository.
1. Extract the original source archive (`source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`) to the Source folder. The folder should now contain a ProjectZ folder, like: `/Source/ProjectZ/..`.
1. Run `dotnet publish -c Release -p:"PublishProfile=FolderProfile"` from the command line, or the Publish command in Visual Studio, to output an optimized build to the `Publish` folder.
1. Copy the `Publish` folder somewhere and rename it accordingly.

## Changelog

See the [CHANGELOG.md](/CHANGELOG.md) file for details.
