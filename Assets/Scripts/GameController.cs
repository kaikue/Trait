using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public Canvas canvas;

	public GameObject traitsListPrefab;

	private bool traitsMode = false;
	private float oldTimeScale;

	private Trait selectedTrait;
	private List<GameObject> traitsLists = new List<GameObject>();

	private void Start()
	{

	}

	private void FixedUpdate()
	{
		if (Input.GetButtonDown("TraitsMode"))
		{
			ToggleTraitsMode();
		}
	}

	private void ToggleTraitsMode()
	{
		if (traitsMode)
		{
			DisableTraitsMode();
		}
		else
		{
			EnableTraitsMode();
		}
	}

	private void EnableTraitsMode()
	{
		print("ENABLE TRAITS MODE");
		traitsMode = true;
		oldTimeScale = Time.timeScale;
		//Time.timeScale = 0;

		GameObject[] traitableObjects = GameObject.FindGameObjectsWithTag("Traitable");
		foreach (GameObject go in traitableObjects)
		{
			GameObject tl = Instantiate(traitsListPrefab, canvas.transform);
			traitsLists.Add(tl);
			tl.transform.position = go.transform.position;
			tl.GetComponent<TraitList>().Populate(go);
		}
	}

	private void DisableTraitsMode()
	{
		print("DISABLE TRAITS MODE");
		traitsMode = false;
		Time.timeScale = oldTimeScale;

		foreach(GameObject tl in traitsLists)
		{
			Destroy(tl);
		}
		selectedTrait = null;
	}

	public void SelectTrait(Trait trait)
	{
		print("SELECT TRAIT " + trait.GetName());
		selectedTrait = trait;
	}

	public void MoveTrait(GameObject newObj)
	{
		if (selectedTrait == null) return;

		print("MOVE TRAIT " + selectedTrait.GetName());

		newObj.AddComponent(selectedTrait.GetType());
		selectedTrait.Remove();

		//TODO: properly repopulate appropriate lists
		DisableTraitsMode();
		EnableTraitsMode();
}
}
