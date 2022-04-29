using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script floor movement.
public class Floatingfloor : MonoBehaviour
{
    public float delta = 0.3f;
    public float speed = 0.2f;
    private Vector3 startpos;

    void Start()
    {
        startpos = transform.position;
    }
    private void FixedUpdate()
    {
        Vector3 v = startpos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}