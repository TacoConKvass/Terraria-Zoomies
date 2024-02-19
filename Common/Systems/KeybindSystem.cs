namespace TerrariaZoomies.Common.Systems;

public class KeybindSystem : ModSystem
{
	public static ModKeybind sprintKeybind { get; private set; }

	public override void Load() {
		sprintKeybind = KeybindLoader.RegisterKeybind(Mod, "Sprint", "Q");
	}

	public override void Unload() {
		sprintKeybind = null;
	}
}