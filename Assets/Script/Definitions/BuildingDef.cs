
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Definitions {
	/// Definition for a building
	public class BuildingDef : TilableDef {
		public int work = 100;
		public new bool blockPath = true;
		public new bool blockStackable = true;
		public new bool supportRoof = true;
		public new bool blockBuilding = true;
		public new bool  blockPlant = true;
	}
}