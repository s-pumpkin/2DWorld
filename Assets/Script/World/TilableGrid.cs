
using UnityEngine;
using spumpkin.Visuals;
using spumpkin.Entities;
using spumpkin.Definitions;

namespace spumpkin.World {
	// Generic grid with no renderer for tilables.
	public  class TilableGrid : LayerGrid {
		public TilableGrid (Vector2Int size) : base(size, Layer.Plant) {
			this.renderer = null;
			this.GenerateBuckets();
		}
	}
}