using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {
    //prêdkoœæ ruchu
    public float speed = 150;
    void FixedUpdate()
    {
        //zwrot horyzontalny
        float h = Input.GetAxisRaw("Horizontal");

        //prêdkoœæ razem z horyzontalnym
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}