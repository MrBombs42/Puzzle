using System;
using UnityEngine;

[Serializable]
public struct PuzzleConfig
{
	public string Key { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Rotation { get; set; }
}
