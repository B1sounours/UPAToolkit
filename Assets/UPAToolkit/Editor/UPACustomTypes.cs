﻿using UnityEngine;

// Each Pixel has a color & a rect to represent
// it's graphics in the editor window.
[System.Serializable]
public struct Pixel {
	public Rect rect;
	public Color color;
	
	//public int layerPos;
}

// Used for switching tools
public enum UPATool {
	PaintBrush,
	Eraser,
	BoxBrush, // TODO: Add BoxBrush
}

// Used for selecting texture export type
enum TextureType {
	sprite = 0,
	texture = 1,
}