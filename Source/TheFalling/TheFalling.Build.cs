// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheFalling : ModuleRules
{
	public TheFalling(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TheFalling",
			"TheFalling/Variant_Platforming",
			"TheFalling/Variant_Platforming/Animation",
			"TheFalling/Variant_Combat",
			"TheFalling/Variant_Combat/AI",
			"TheFalling/Variant_Combat/Animation",
			"TheFalling/Variant_Combat/Gameplay",
			"TheFalling/Variant_Combat/Interfaces",
			"TheFalling/Variant_Combat/UI",
			"TheFalling/Variant_SideScrolling",
			"TheFalling/Variant_SideScrolling/AI",
			"TheFalling/Variant_SideScrolling/Gameplay",
			"TheFalling/Variant_SideScrolling/Interfaces",
			"TheFalling/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
