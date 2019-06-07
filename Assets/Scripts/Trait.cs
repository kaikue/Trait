using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trait : MonoBehaviour
{

	public bool IsRemoved { get; private set; } = false;

	protected virtual void Start()
	{

	}

	public virtual void Remove()
	{
		IsRemoved = true;
		Destroy(this);
	}

	public string GetName()
	{
		return GetType().Name;
	}
}
