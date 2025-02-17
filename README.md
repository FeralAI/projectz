# ProjectZ

This is the source code for ProjectZ, and *only* the source code -- assets (sprite sheets, sound effects etc.) must be provided by the user. The project builds with MonoGame 3.8.1.303, which is newer than the version ProjectZ 1.0.0 originally shipped with.

## Requirements

* .NET 6 SDK
	* Visual Studio 2022 is recommended, but not required to build the project
* The original source archive, which includes all binary assets used by the game (sprite sheets, sound effects, music in Game Boy Sound format) and the English language script. `source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`

## Build Instructions

1. Clone this repository.
1. Extract the original source archive (`source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`) to the Source folder. The folder should contain a ProjectZ folder.
1. Run `dotnet publish -c Release -p:"PublishProfile=FolderProfile"` from the command line, or the Publish command in Visual Studio, to output an optimized build to the `Publish` folder.
1. Copy the `Publish` folder somewhere and rename it accordingly.
