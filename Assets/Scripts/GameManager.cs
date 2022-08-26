using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {



	public Transform playerSpawnPoint;
	[HideInInspector]
	public GameObject jugador;
	public string pjTag;
	public static GameManager instance { get; private set;  }

	public void Awake()
    {
		if (instance == null)
        {
			instance = this;
        }
    }
	void Start () 
	{
		
		jugador = GameObject.FindGameObjectWithTag("Player");
		jugador.transform.position = playerSpawnPoint.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
