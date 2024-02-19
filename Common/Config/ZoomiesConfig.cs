using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace TerrariaZoomies.Common.Config;

public class ZoomiesConfig : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ClientSide;

	[ReloadRequired]
	[DefaultValue(false)]
	//[Label()]
	//[Tooltip()]
	public bool SprintToggle;

	[ReloadRequired]
	[DefaultValue(10)]
	public int mphSprintBoost;
}