using UnrealBuildTool;

public class Game_MidServerTarget : TargetRules
{
	public Game_MidServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Game_Mid");
	}
}
