

namespace spumpkin.Helpers {
	// Generate hashes for various objects
	public static class HashUtils {
		/// This is temporary, need to make a real class here with stuff like this.
		public static int HashBoolArray(bool[] arr) {
			int hash = arr.Length;
			foreach (bool v in arr) {
				hash = unchecked(hash*314159 + ((!v) ? 1 : 2));
			}
			return hash;
		}
	}
}