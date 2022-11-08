using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class añañin : MonoBehaviour
{
    private Animator anim;
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;
    public float x, y;

    public bool isAttacking;
    public bool isMoving;
    public float kick = 10f;

    void Start()
    {
          anim= GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }

    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
    }
}
