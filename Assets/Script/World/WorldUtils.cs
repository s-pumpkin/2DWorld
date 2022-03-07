
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Entities;
using spumpkin.Helpers;
using spumpkin.Definitions;
using spumpkin.Characters.AI;

namespace spumpkin.World {
	public struct BucketResult {
		public bool result;
		public LayerGridBucket bucket;
		public Tilable tilable;
	}

	public static partial class WorldUtils {
		public static Tilable ClosestTilableFromEnum (Vector2Int position, IEnumerable<Tilable> tilables) {
			Tilable result = null;
			float minDistance = float.MaxValue;
			foreach (Tilable tilable in tilables) {
				float currentMinDistance = Utils.Distance(position, tilable.position);
				if (currentMinDistance < minDistance) {
					minDistance = currentMinDistance;
					result = tilable;
				}
			}

			return result;
		}

	}
}