using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
	private Vector3 offset;
	private bool isDragging = false;

	private void OnMouseDown()
	{
		offset = gameObject.transform.position - GetMouseWorldPosition();
		isDragging = true;
	}

	private void OnMouseUp()
	{
		isDragging = false;
	}

	private void Update()
	{
		if (isDragging)
		{
			Vector3 newPosition = GetMouseWorldPosition() + offset;
			gameObject.transform.position = newPosition;
		}
	}

	private Vector3 GetMouseWorldPosition()
	{
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = Camera.main.nearClipPlane;
		return Camera.main.ScreenToWorldPoint(mousePosition);
	}
}