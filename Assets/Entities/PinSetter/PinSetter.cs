using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour
{
	public Text PinStandingCountText;

	private Pin[] _pins;

	// Use this for initialization
	void Start () {
		_pins = GameObject.Find("Pin Layout").GetComponentsInChildren<Pin>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Ball>())
		{
			PinStandingCountText.text = CountStanding().ToString();
		}
	}

	private int CountStanding()
	{
		int standingPins = 0;

		foreach (Pin pin in _pins)
		{
			if (pin.IsStanding())
			{
				standingPins += 1;
			}
		}

		return standingPins;
	}
}
