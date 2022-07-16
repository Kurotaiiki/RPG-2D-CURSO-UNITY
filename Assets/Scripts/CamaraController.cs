using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamaraController : MonoBehaviour {

	// Use this for initialization
	private CinemachineVirtualCamera cv;

	private void Start ()
    {
		cv = GetComponent<CinemachineVirtualCamera>();
		Transform jugador = GameManager.instance.jugador.transform;
		Debug.Log(jugador.tag);
		cv.m_Follow = jugador;
    }
}
