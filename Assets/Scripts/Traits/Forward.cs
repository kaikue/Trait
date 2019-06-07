using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : Trait
{
	private bool wasFlipped;

	protected override void Start()
	{
		base.Start();

		/*wasFlipped = transform.localScale.x < 0;
		if (wasFlipped)
		{
			Flip();
		}*/
	}

	public override void Remove()
	{
		base.Remove();

		/*if (wasFlipped)
		{
			Flip();
		}*/
	}

	/*private void Flip()
	{
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}*/

}
