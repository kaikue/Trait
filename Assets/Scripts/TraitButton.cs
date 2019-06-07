using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraitButton : MonoBehaviour
{
	public Trait trait;

	private GameController gc;

	private void Start()
	{
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	public void SetTrait(Trait trait)
	{
		this.trait = trait;
		GetComponentInChildren<Text>().text = trait.GetName();
	}

	public void Click()
	{
		gc.SelectTrait(trait);
	}
}
