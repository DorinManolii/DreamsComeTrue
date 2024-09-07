using UnrealBuildTool;

public class Game_MidTarget : TargetRules
{
	public Game_MidTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Game_Mid");
	}
}
