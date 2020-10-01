#!/bin/sh

echo AUDIO
dotnet pack Audio.AL/Audio.AL.csproj --configuration Release --output publish/packages --force
dotnet pack Audio.Sounding/Audio.Sounding.csproj --configuration Release --output publish/packages --force
dotnet pack Audio.Sounding.Formats.Wav/Audio.Sounding.Formats.Wav.csproj --configuration Release --output publish/packages --force
dotnet pack Audio.Sounding.Formats.Yaf/Audio.Sounding.Formats.Yaf.csproj --configuration Release --output publish/packages --force

echo GAME & COMPONENTS
dotnet pack Components/Components.csproj --configuration Release --output publish/packages --force
dotnet pack Gaming.Game/Gaming.Game.csproj --configuration Release --output publish/packages --force
dotnet pack Gaming.GameLoop/Gaming.GameLoop.csproj --configuration Release --output publish/packages --force

echo GRAPHICS
dotnet pack Graphics.Types/Graphics.Types.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.Math/Graphics.Math.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.GL/Graphics.GL.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.Imaging/Graphics.Imaging.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.Imaging.Formats.Bmp/Graphics.Imaging.Formats.Bmp.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.Imaging.Formats.Png/Graphics.Imaging.Formats.Png.csproj --configuration Release --output publish/packages --force
dotnet pack Graphics.Imaging.Formats.Yaf/Graphics.Imaging.Formats.Yaf.csproj --configuration Release --output publish/packages --force

echo INPUT
dotnet pack Input/Input.csproj --configuration Release --output publish/packages --force

echo WINDOWING
dotnet pack Windowing/Windowing.csproj --configuration Release --output publish/packages --force

echo UTILS
dotnet pack Utils.NativeLibResolver.NetCore3/Utils.NativeLibResolver.NetCore3.csproj --configuration Release --output publish/packages --force