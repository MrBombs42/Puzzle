using DG.Tweening;
using UnityEngine;

namespace Assets.Script
{
	public class PuzzlePiece : MonoBehaviour
	{
		[SerializeField] private PuzzleConfig _config;


		public void SaveConfig()
		{
			_config.Position = transform.position;
			_config.Rotation = transform.rotation.eulerAngles;
		}

		public void ReturnHome()
		{
			transform.DOMove(_config.Position, 1);
		}
	}
}
