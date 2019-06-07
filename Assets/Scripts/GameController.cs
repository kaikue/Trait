using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private bool traitsMode = false;
	private float oldTimeScale;

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
			EnableTraitsMode();
		}
		else
		{
			DisableTraitsMode();
		}
	}

	private void EnableTraitsMode()
	{
		traitsMode = true;
		oldTimeScale = Time.timeScale;
		Time.timeScale = 0;

		GameObject[] traitableObjects = GameObject.FindGameObjectsWithTag("Traitable");
		foreach (GameObject go in traitableObjects)
		{
			//show traits list
		}
	}

	private void DisableTraitsMode()
	{
		traitsMode = false;
		Time.timeScale = oldTimeScale;

		//hide all traits
	}
}
