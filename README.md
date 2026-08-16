# Mp3Merger

A lightweight Windows desktop app for merging multiple MP3 files into a single file.

## Features

- Add multiple `.mp3` files through a file picker
- Reorder files by dragging them within the list
- Move files up/down or remove them before merging
- Choose an output folder and merge with one click
- Progress bar shows merge progress

## Requirements

- Windows
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) runtime (usually already installed on modern Windows)

## Download

Grab the latest build from the [Releases](../../releases) page, unzip it, and run `Mp3Merger.exe`.

## Usage

1. Launch `Mp3Merger.exe`.
2. Click **Select Files** and choose two or more `.mp3` files.
3. Drag items in the list to reorder them (or use the move up/down buttons) — this is the order they will be merged in.
4. Click **Select Output Path** and choose a destination folder.
5. Click **Start** to merge the files into `Mp3MergerOut.mp3` in the chosen folder.

## Building from source

Open `Mp3Merger.sln` in Visual Studio (2019 or later, with the .NET desktop development workload) and build the `Mp3Merger` project, or build from the command line with MSBuild:

```
msbuild Mp3Merger.sln /p:Configuration=Release
```

The built executable will be in `Mp3Merger/bin/Release`.

## Project structure

- `Mp3Merger/Form1.cs` — main window and merge logic
- `Mp3Merger/Models/FilesLBModel.cs` — list box item model for selected files
- `Mp3Merger/Program.cs` — application entry point
