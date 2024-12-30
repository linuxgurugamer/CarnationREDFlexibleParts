Changelog

0.7.0.5
	Updated version file to use github for new version info
	Copied full web page to README-WEB.md

0.7.0.4
	Fixed path for loading images (broken by new launcher)

0.7.0.3
	Fixed loading of texture (broken by new launcher)

0.7.0.2
	Fixed bad build

0.7.0.1 
	Fixed loading of initial dds textures, changed location of folder caused an error

0.7.0.0
	Adoption by Linuxgurugamer
	Fixed names of two part config files (no dot before cfg)	
	Moved Texture folder into the PluginData folder to avoid KSP loading textures unnecessarily 
	This release includes textures from the following mods:
		Basic Procedural Textures, by Tyko Tex, MIT license
		MainSailor's Procedural Textures, by MainSailor, CC-BY-NC-SA-4.0 license
		Rusty Textures for Procedural parts, by Gaga_X, MIT license
		Freedom Textures, by Freedom & PhineasFreak, MIT license
		Derivative Textures, by RoboRay, CC-BY-NC-SA-4.0 license
	Instructions provided for manual install of the Blackheart textures, which can't be included due to license restrictions
		Textures_README_UPDATE

**v0.6 2020/4/4**  
　　* Add support for chamfer corners, NOT COMPATIBLE WITH OLD SAVEGAME  
　　* Add support for custom Section Corner shapes, defined in CRFPSectionCornerDefinitions.cfg  
　　* Add support for R&D part size limit, see CRFPTechLimits.cfg  
　　* Add a "#" button to the UI panel which enables numeric input for parameters  
　　* New "Link" feature: click the link button on the UI panel to update the connected part's section simultaneously.  
　　* Modify cfg: CRFPTankTypeDefinition: replace dryMassCalcByArea by dryMassCalcCoeff, 0: dry mass by volume, 1: dry mass by area  
　　* Tweak cfg: Structural parts now weigh more.  
　　* Tweak: When handle gizmos are activated, use RMB to switch between parts  
　　* Tweak: radius indices tips now only show at the part end which mouse is pointing to  
　　* Fix: issues with RealFuels  
　　* Fix: Drag Cube is now updated properly.  
　　* Fix: buoyancy  
　　* Fix: the part joint is not strong enough.  
　　* Fix: part disappears when both Top width and height are set to 0 and all Top radius are set to -1  
  
**v0.5 Initial release**  