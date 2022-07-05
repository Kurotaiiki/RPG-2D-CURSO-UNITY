using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactivo : MonoBehaviour {

	private Collider2D miColisionador;
	public UnityEvent onInteraccion;





	void Start () 
	{
		miColisionador = GetComponent<Collider2D>();	
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
		onInteraccion.Invoke();
    }
	
	
}
