
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Definitions {
	// Definition for a color palette 
	[System.Serializable]
	public class ColorPaletteDef : Def {
		public List<Color> colors = new List<Color>();

		public Color GetRandom() {
			return this.colors[Random.Range(0, this.colors.Count)];
		}

		public int GetRandomID() {
			return Random.Range(0, this.colors.Count);
		}
	}

	[System.Serializable]
	public class NamedColorPaletteDef : Def {
		public Dictionary<string, Color> colors = new Dictionary<string, Color>();
	}
}