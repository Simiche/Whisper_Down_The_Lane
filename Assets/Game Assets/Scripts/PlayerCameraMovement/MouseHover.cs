using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
	private Color basicColor = Color.black;
	private Color hoverColor = Color.green;
	private Renderer renderer;

	void Start()
	{
		renderer = GetComponentInChildren<Renderer>();
		renderer.material.color = basicColor;
	}

	void OnMouseEnter()
	{
		renderer.material.color = hoverColor;
	}

	void OnMouseExit()
	{
		renderer.material.color = basicColor;
	}
}