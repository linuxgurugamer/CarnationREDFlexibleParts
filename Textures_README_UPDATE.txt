To get the Blackheart textures installed:

1.  Copy over
2.  Create ModsExceptions.txt
2.  Run DDS4KSPcs.exe on the entire directory
3.  Delete all backup (ddsified) files
4.  Delete all cfg files
5.  Delete log file


Command Line Instructions for Windows
=====================================
cd GameData\CarnationREDFlexibleParts\Textures
echo " " > ModExceptions.txt
mkdir Blackheart
xcopy ..\..\blackheart\ProceduralParts Blackheart /s
cd Blackheart
DDS4KSPcs.exe


This release includes textures from the following mods:

Basic Procedural Textures, by Tyko Tex, MIT license
MainSailor's Procedural Textures, by MainSailor, CC-BY-NC-SA-4.0 license
Rusty Textures for Procedural parts, by Gaga_X, MIT license
Freedom Textures, by Freedom & PhineasFreak, MIT license
Defivative Textures, by RoboRay, CC-BY-NC-SA-4.0 license
