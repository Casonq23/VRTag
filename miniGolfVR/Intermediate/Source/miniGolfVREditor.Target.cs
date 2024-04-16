using UnrealBuildTool;

public class miniGolfVREditorTarget : TargetRules
{
	public miniGolfVREditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("miniGolfVR");
	}
}
