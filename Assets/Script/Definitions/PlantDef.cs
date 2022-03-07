
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Definitions {
	/// Definition for a plant
	[System.Serializable]
	public class PlantDef : Def {
		public float probability = 0f;
		public float minFertility = 0f;
		public int states = 5;
		public float lifetime = 2f; // Days
	}
}