using UnrealBuildTool;

public class Game_MidEditorTarget : TargetRules
{
	public Game_MidEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Game_Mid");
	}
}
