using UnrealBuildTool;

public class miniGolfVRClientTarget : TargetRules
{
	public miniGolfVRClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("miniGolfVR");
	}
}
