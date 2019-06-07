using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trait : MonoBehaviour
{
	
	protected virtual void Start()
	{

	}

	public virtual void Remove()
	{
		Destroy(this);
	}
}
