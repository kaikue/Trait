using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraitList : MonoBehaviour
{
	public Transform content;

	public GameObject buttonPrefab;
	
	public void Populate(GameObject traitableObject)
	{
		GetComponentInChildren<ClickableTraitList>().traitableObject = traitableObject;

		Trait[] traits = traitableObject.GetComponents<Trait>();
		foreach(Trait trait in traits)
		{
			if (!trait.IsRemoved)
			{
				AddTrait(trait);
			}
		}
	}

	private void AddTrait(Trait trait)
	{
		GameObject button = Instantiate(buttonPrefab, content);
		TraitButton tb = button.GetComponent<TraitButton>();
		tb.SetTrait(trait);
	}
}
