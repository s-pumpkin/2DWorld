
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Definitions {
	/// Definition for an animal

	[System.Serializable]
	public class LivingDef : Def {
		public string shortDesc;
		public GraphicDef graphics;
	}

	[System.Serializable]
	public class AnimalDef : LivingDef {
		
	}
}