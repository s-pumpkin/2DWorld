
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Definitions;
using spumpkin.Helpers;
using spumpkin.Visuals;
using spumpkin.World;

namespace spumpkin.Entities {
	/// Stackable tilable	
	public class Stackable : Tilable {
		public Inventory inventory { get; protected set; }
		public StockArea area  { get; protected set; }

		public Stackable(Vector2Int position, TilableDef def, int count) {
			this.position = position;
			this.def = def;
			this.inventory = new Inventory(this, count);
			this.mainGraphic = GraphicInstance.GetNew(this.def.graphics);
			this.area = null;
			this.SetNeigbours();
			Loki.stackableLabelController.AddLabel(this);
			if (count > 0) {
				WorldUtils.AddStackable(def, this);
			}
			this.inventory.OnClear += delegate {
				WorldUtils.ClearStackable(this.inventory.def, this);
			};
			this.inventory.OnAdd += delegate {
				WorldUtils.AddStackable(this.inventory.def, this);
			};
			this.inventory.OnChangeCount += delegate(int change) {
				WorldUtils.UpdateStackableCount(this.inventory.def, change);
			};
		}

		public Stackable(Vector2Int position, StockArea area) {
			this.position = position;
			this.def = Defs.empty;
			this.area = area;
			this.inventory = null;
			this.mainGraphic = GraphicInstance.GetNew(
				this.def.graphics, 
				this.area.color, 
				Res.TextureUnicolor(this.area.color),
				1
			);
			
		}
	}
}