
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Definitions {
	/// Definition for a building
	[System.Serializable]
	public class RecipeDef : Def {
		public Dictionary<TilableDef, int> reqs = new Dictionary<TilableDef, int>();
	}
}