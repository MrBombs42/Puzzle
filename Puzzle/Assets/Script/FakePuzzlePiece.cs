using UnityEngine;

namespace Assets.Script
{
	public class FakePuzzlePiece : MonoBehaviour
	{
		public string Key;

		private void Awake()
		{
			Key = name;
		}
	}
}
