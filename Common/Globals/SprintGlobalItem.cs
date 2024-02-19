using TerrariaZoomies.Common.Players;

namespace TerrariaZoomies.Common.Globals;

public class SprintGlobalItem : GlobalItem
{
	public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
		if (player.GetModPlayer<SprintPlayer>().sprinting && player.velocity.Length() >= 7f) {
			base.UpdateAccessory(item, player, hideVisual);
			int primaryDust = -1;
			int secondaryDust = -1;
			
			switch (item.type) {
				case ItemID.HermesBoots:
					primaryDust = DustID.Dirt;
					break;
				case ItemID.FlurryBoots:
					primaryDust = DustID.Snow;
					break;
				case ItemID.SandBoots:
					primaryDust = DustID.Sand;
					break;
				case ItemID.SailfishBoots:
					primaryDust = DustID.ManaRegeneration;
					break;
				case ItemID.AmphibianBoots:
					primaryDust = DustID.ManaRegeneration;
					break;
				case ItemID.SpectreBoots:
					primaryDust = DustID.Cloud;
					secondaryDust = DustID.Smoke;
					break;
				case ItemID.FairyBoots:
					primaryDust = DustID.JungleSpore;
					break;
				case ItemID.LightningBoots:
					primaryDust = DustID.Electric;
					secondaryDust = DustID.SolarFlare;
					break;
				case ItemID.FrostsparkBoots:
					primaryDust = DustID.Electric;
					secondaryDust = DustID.Ice;
					break;
				case ItemID.TerrasparkBoots:
					primaryDust = DustID.Electric;
					secondaryDust = DustID.SolarFlare;
					break;
			}

			if (primaryDust != -1) {
				Dust.NewDust(player.Center + new Vector2(0, 14), 8, 8, primaryDust, 1.3f * -player.direction, -1);
			}
			if (secondaryDust != -1) {
				Dust.NewDust(player.Center + new Vector2(0, 14), 8, 8, secondaryDust, 1.3f * -player.direction, -1);
			}
		}
	}
}