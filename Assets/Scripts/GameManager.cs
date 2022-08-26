using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {



	public Transform playerSpawnPoint;
	[HideInInspector]
	public GameObject jugador;
	public string pjTag;
	public static GameManager instance;

	// Use this for initialization
	void Start () 
	{
		instance = this;
		jugador = GameObject.FindGameObjectWithTag(pjTag);
		jugador.transform.position = playerSpawnPoint.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
