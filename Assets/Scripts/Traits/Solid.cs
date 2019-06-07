using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solid : Trait
{
	private Collider2D col;

	protected override void Start()
	{
		base.Start();

		col = GetComponent<Collider2D>();
		if (col == null)
		{
			col = gameObject.AddComponent<BoxCollider2D>();
		}
	}

	public override void Remove()
	{
		base.Remove();

		Destroy(col);
	}

}
