using UnrealBuildTool;

public class miniGolfVRTarget : TargetRules
{
	public miniGolfVRTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("miniGolfVR");
	}
}
