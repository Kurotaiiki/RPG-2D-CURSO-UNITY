using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] private float velocidad = 3;

	private InputPlayer inputJugador;
	private float horizontal;
	private float vertical;
	private Rigidbody2D miRigidbody2D;
	private Animator animator;
	private SpriteRenderer miSprite;
    int correrHashCode;


	void Start () {
		inputJugador = GetComponent<InputPlayer>();
		miRigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		miSprite = GetComponent<SpriteRenderer>();
        correrHashCode = Animator.StringToHash("Corriendo");		
	}



	void Update()
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;

        //VoltearSprite();

        if (vertical != 0 || horizontal != 0)
        {
            SetearXYAnimator();
            animator.SetBool(correrHashCode, true);
        }
        else
        {
            animator.SetBool(correrHashCode, false);
            
        }

    }




    private void VoltearSprite()
    {
        if (horizontal > 0 && Mathf.Abs(horizontal) > Mathf.Abs(vertical))
        {
            miSprite.flipX = true;
        }
        else if (horizontal != 0)
        {
            miSprite.flipX = false;
        }
    }

    private void SetearXYAnimator()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }
    void FixedUpdate () {

		#region MOVIMIENTO 

		Vector2 vectorVelocidad = new Vector2 (horizontal, vertical)*velocidad;
		miRigidbody2D.velocity = vectorVelocidad;

        #endregion MOVIMIENTO

    }


}
