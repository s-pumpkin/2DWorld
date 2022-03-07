
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Definitions;
using spumpkin.Helpers;
using spumpkin.Visuals;

namespace spumpkin.Entities {
	/// Mountain tilable	
	public class Mountain : Tilable {
		private ConnectedTilable _connectedUtility;

		public Mountain(Vector2Int position, TilableDef def) {
			this.position = position;
			this.def = def;
			
			this.mainGraphic = GraphicInstance.GetNew(
				this.def.graphics,
				default(Color),
				Res.textures[this.def.graphics.textureName+"_0"],
				1
			);
			this._connectedUtility = new ConnectedTilable(this);
			this.addGraphics = new Dictionary<string, GraphicInstance>();
		}

		public override void UpdateGraphics() {
			this._connectedUtility.UpdateGraphics();
		}
	}
}