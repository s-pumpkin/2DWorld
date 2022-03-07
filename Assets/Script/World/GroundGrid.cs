
using UnityEngine;
using spumpkin.Visuals;
using spumpkin.Entities;
using spumpkin.Definitions;

namespace spumpkin.World {
	// Grid used for the ground with a special renderer (BucketGroundRenderer)
	public  class GroundGrid : LayerGrid {
		public GroundGrid (Vector2Int size) : base(size, Layer.Ground) {
			this.renderer = typeof(BucketGroundRenderer);
			this.GenerateBuckets();
		}
	}
}