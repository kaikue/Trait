using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableTraitList : MonoBehaviour, IPointerClickHandler
{
	public GameObject traitableObject;

	private GameController gc;

	private void Start()
	{
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		gc.MoveTrait(traitableObject);
	}
}
