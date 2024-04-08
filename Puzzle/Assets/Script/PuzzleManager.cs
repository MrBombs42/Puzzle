using UnityEngine;

namespace Assets.Script
{
	public class PuzzleManager : MonoBehaviour
	{
		[SerializeField] private PuzzlePiece[] _pieces;
		[SerializeField] private float _shuffleRange = 5;

		private void Awake()
		{
			_pieces = GetComponentsInChildren<PuzzlePiece>(true);

			foreach (var piece in _pieces)
			{
				piece.SaveConfig();
			}
		}

		private void Start()
		{
			foreach (var piece in _pieces)
			{
				piece.MoveAndInit(piece.transform.position + Random.insideUnitSphere * _shuffleRange);
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
