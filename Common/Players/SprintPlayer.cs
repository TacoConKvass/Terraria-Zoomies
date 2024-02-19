using TerrariaZoomies.Common.Config;
using TerrariaZoomies.Common.Systems;

namespace TerrariaZoomies.Common.Players;

public class SprintPlayer : ModPlayer
{
	public bool sprinting = false;
	private ZoomiesConfig configInstance => ModContent.GetInstance<ZoomiesConfig>();

	public override void PreUpdate() {
		if (configInstance.SprintToggle) {
			sprinting = KeybindSystem.sprintKeybind.JustPressed ? !sprinting : sprinting;
			return;
		}

		sprinting = false;
		if (KeybindSystem.sprintKeybind.Current) {
			sprinting = true;
		}
	}

	public override void PostUpdateRunSpeeds() {
		if (sprinting) { 
			Player.accRunSpeed += configInstance.mphSprintBoost / 5f;
			Player.runAcceleration += 0.2f;
		}
	}
}
