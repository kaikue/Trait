using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : Trait
{
	private Color oldColor;

	protected override void Start()
	{
		base.Start();

		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		if (sr != null)
		{
			oldColor = sr.color;
			sr.color = Color.red;
		}
	}

	public override void Remove()
	{
		base.Remove();

		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		if (sr != null)
		{
			sr.color = oldColor;
		}
	}

}
