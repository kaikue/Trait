using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlled : Trait
{
	private const float MOVE_SPEED = 5.0f;

	private Trait directionTrait;

	private Rigidbody2D rb;

	protected override void Start()
	{
		base.Start();

		rb = GetComponent<Rigidbody2D>();
		if (rb == null)
		{
			rb = gameObject.AddComponent<Rigidbody2D>();
			rb.constraints = RigidbodyConstraints2D.FreezeRotation;
		}

		directionTrait = gameObject.AddComponent<Forward>();
	}

	public override void Remove()
	{
		base.Remove();

		//TODO: remove rigidbody? only if this one added it and no other one requires it
	}

	private void FixedUpdate()
	{
		float hVel = Input.GetAxisRaw("Horizontal") * MOVE_SPEED;

		if (hVel < 0 && directionTrait is Forward)
		{
			directionTrait.Remove();
			directionTrait = gameObject.AddComponent<Backward>();
		}
		else if (hVel > 0 && directionTrait is Backward)
		{
			directionTrait.Remove();
			directionTrait = gameObject.AddComponent<Forward>();
		}

		rb.velocity = new Vector2(hVel, rb.velocity.y);
	}

}
