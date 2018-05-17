using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProperties : MonoBehaviour {

	[Range(1.0f, 100.0f)]
	public float attack;
	[Range(0.0f, 1000.0f)]
	public float life;
	[Range(1.0f, 100.0f)]
	public float agility;
	[Range(1.0f, 100.0f)]
	public float speed;

}
