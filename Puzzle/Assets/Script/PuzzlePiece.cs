using DG.Tweening;
using UnityEngine;

namespace Assets.Script
{
	public class PuzzlePiece : MonoBehaviour
	{
		[SerializeField] private PuzzleConfig _config;
		[SerializeField] private float _minDistance = 1f;
		private float _duration = 0.5f;
		private Ease _easeType = Ease.OutQuad;

		private bool _checkDistance = false;

		public void SaveConfig()
		{
			_config.Key = name;
			_config.Position = transform.position;
			_config.Rotation = transform.rotation.eulerAngles;
		}

		public void ReturnHome()
		{
			transform.DOMove(_config.Position, 1);
		}

		public void MoveAndInit(Vector3 position)
		{
			transform.DOMove(position, 1).OnComplete(() => _checkDistance = true);
		}

		public void Snap()
		{
			if (TryGetComponent(out DragAndDrop dragAndDrop))
			{
				dragAndDrop.Release();
			}
			transform.DOMove(_config.Position, _duration).SetEase(_easeType);
		}

		private void Update()
		{
			if (!_checkDistance)
			{
				return;
			}

			var dist = _config.Position - transform.position;
			if (Vector3.Magnitude(dist) < _minDistance)
			{
				Snap();
			}
		}
	}
}
