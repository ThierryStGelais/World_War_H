﻿using UnityEngine;
using System.Collections;

public class Objectifs : MonoBehaviour {

	public bool PorteObjectif = false;

	void OnTriggerEnter(Collider other) 
	{
		PorteObjectif = true;
		Destroy (other.gameObject);
	}
}
