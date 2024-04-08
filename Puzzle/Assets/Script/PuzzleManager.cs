using UnityEngine;

namespace Assets.Script
{
	public class PuzzleManager : MonoBehaviour
	{
		[SerializeField] private PuzzlePiece[] _pieces;

		private void Awake()
		{
			_pieces = GetComponentsInChildren<PuzzlePiece>(true);

			foreach (var piece in _pieces)
			{
				piece.SaveConfig();
			}
		}


		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				foreach (var piece in _pieces)
				{
					piece.ReturnHome();
				}
			}
		}
	}
}
