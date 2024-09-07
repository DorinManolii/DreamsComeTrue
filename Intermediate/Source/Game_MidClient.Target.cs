using UnrealBuildTool;

public class Game_MidClientTarget : TargetRules
{
	public Game_MidClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Game_Mid");
	}
}
