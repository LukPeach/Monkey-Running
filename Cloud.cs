using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script of movement Cloud.
public class Cloud : MonoBehaviour
{
    public float delta = 0.3f;
    public float speed = 0.2f;
    private Vector3 startpos;

    void Start()
    {
        startpos = transform.position;
    }

    void Update()
    {
        Vector3 v = startpos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
