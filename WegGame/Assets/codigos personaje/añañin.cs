using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class añañin : MonoBehaviour
{
         public float velocidadMovimiento = 5.0f;
        public float velocidadRotacion = 200.0f;
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;
     private Animator anim;
     public float x, y;
void Start()
    {
          anim= GetComponent<Animator>();
    }
    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
    }
}
