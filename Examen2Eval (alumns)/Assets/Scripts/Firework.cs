using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{
    public float force, minTimeToExplode, maxTimeToExplode;
    public int minFireworks, maxFireworks;
    public GameObject fireworkPrefab;
    public int maxExplosions = 3;

    private Rigidbody2D _rb;
    private SpriteRenderer _rend;
    private int _count = 0;
    private Vector2 _dir = Vector2.up;
    private float currentTime, timeToExplode;
    private int index = 0;
    private bool Explote = false;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        _rb.AddForce(Vector2.up * force * _rb.gravityScale, ForceMode2D.Impulse);

        //Todo esto me da error y crasea unity y lo tengo que cerrar con administrador de tareas
        //if(currentTime >= timeToExplode && !Explote)
        //{       
        //    int FireNum = UnityEngine.Random.Range(2, 5);


        //    for (int i = 0; i < FireNum; i++)
        //    {
        //        GameObject Firework = Instantiate(fireworkPrefab, transform.position, Quaternion.identity);

        //        if (index == 1)
        //        {
        //            Destroy(Firework);
        //        }
        //    }

        //    Destroy(gameObject);

        //    Explote = true;
        //}
    }
}
