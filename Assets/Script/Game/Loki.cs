
using spumpkin.Controllers;
using spumpkin.World;
using spumpkin.Definitions;
using spumpkin.Helpers;
using spumpkin.Entities;

namespace spumpkin {
	// Static class use to find stuff in our game.
	public static class Loki {
		public static GameManager manager;
		public static CameraController cameraController { get { return Loki.manager.cameraController; } }
		public static StackableLabelController stackableLabelController { get { return Loki.manager.stackableLabelController; } }
		public static Map map { get { return Loki.manager.map; } }
		public static Tick tick { get { return Loki.manager.tick; } }

		/// Load all statics definitions
		public static void LoadStatics() {
			Res.Load(); // Load all our resources;
			DirectionUtils.LoadStatics(); // Set neighbours;
			Defs.LoadDefaultsDefs(); // Empty def
			Defs.LoadGroundsFromCode(); // Loading our ground definitions;
			Defs.LoadPlantsFromCode(); // Loading our plants definitions;
			Defs.LoadMountainsFromCode(); // Loading our mountains definitions;
			Defs.LoadStackablesFromCode(); // Loading our stackables definitions;
			Defs.LoadColorPalletsFromCode(); // Loading our pallets;
			Defs.LoadBuildingsFromCode();
			Defs.LoadAnimalsFromCode(); // Loading animals;
			Defs.LoadTasksFromCode(); // Loading tasks;
			Defs.LoadMenuOrdersFromCode(); // Loading orders;
		}

		/// Register the game manager when we start a game.
		public static void NewGame(GameManager manager) {
			Loki.manager = manager;
		}
	}
}