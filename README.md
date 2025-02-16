# ProjectZ

This is the source code for ProjectZ, and *only* the source code -- assets (sprite sheets, sound effects etc.) must be provided by the user. The project builds with MonoGame 3.8.1.303, which is newer than the version ProjectZ 1.0.0 originally shipped with.

## Requirements

* .NET 6
* Visual Studio 2022
* MonoGame 3.8.1.303 (does not support versions of Visual Studio earlier than 2022)
* The original source archive, which includes all binary assets used by the game (sprite sheets, sound effects, music in Game Boy Sound format) and the English language script. `source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`

## Build Instructions

* Clone repo somewhere.
* Extract the original source archive (`source.7z md5: 4871f9fce7ae06d14aedbb33a88b18a8`) to the Source folder. The folder should contain a ProjectZ folder.
* Run Publish on ProjectZ in from Visual Studio, or run `dotnet publish -c Release -p:"PublishProfile=FolderProfile"` from the command line, to run a release build and output a full package to the `Publish` folder.
