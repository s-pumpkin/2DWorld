
namespace spumpkin.Definitions {
	// Grahpic Layer / Altitude for our tilables.
	[System.Serializable]
	public enum TilableType : ushort {
		Undefined,
		Grass,
		Tree,
		Plant, // Harvestable
		Building,
		BuildingConnected,
		Recipe
	}
}