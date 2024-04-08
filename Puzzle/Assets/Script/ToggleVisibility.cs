using UnityEngine;

namespace Assets.Script
{
	public class ToggleVisibility : MonoBehaviour
	{
		[SerializeField] private FakePuzzlePiece[] _pieces;

		private bool _isVisible;

		private void Awake()
		{
			_pieces = GetComponentsInChildren<FakePuzzlePiece>(true);

			foreach (var piece in _pieces)
			{
				piece.gameObject.SetActive(false);
				_isVisible = false;
			}
		}


		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.H))
			{
				_isVisible = !_isVisible;
				foreach (var piece in _pieces)
				{
					piece.gameObject.SetActive(_isVisible);
				}
			}
		}
	}
}
