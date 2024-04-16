using UnrealBuildTool;

public class miniGolfVRServerTarget : TargetRules
{
	public miniGolfVRServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("miniGolfVR");
	}
}
