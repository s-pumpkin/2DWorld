
using UnityEngine;
using spumpkin.Definitions;
using spumpkin.Visuals;

namespace spumpkin.Entities {
	/// Ground Tilable
	public class Ground : Tilable {
		public Ground(Vector2Int position, TilableDef def) {
			this.position = position;
			this.def = def;
			this.mainGraphic = GraphicInstance.GetNew(def.graphics);
		}

		/// Get the correct ground definition by height.
		public static TilableDef GroundByHeight(float height) {
			foreach (TilableDef tilableDef in Defs.groundsByHeight.Values) {
				if (height <= tilableDef.groundDef.maxHeight) {
					return tilableDef;
				}
			}

			return Defs.grounds["water"];
		}
	}
}