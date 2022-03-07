
namespace spumpkin.Definitions {
	// Grahpic Layer / Altitude for our tilables.
	[System.Serializable]
	public enum Layer : ushort {
		Undefined, // This is used if we don't want a grahpic representation.
		Ground, // Ground layer.
		Helpers,
		Mountain,
		Building,
		Stackable,
		Plant,
		Orders,
		FX,
		Count // Count is just a nice trick to get the enum length.
	}

	// Layer utilities
	public static class LayerUtils {
		/// Get the height of a layer (z position)
		public static float Height (Layer layer) {
			return (int)layer * - 1f;
		}
	}
}