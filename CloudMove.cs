using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script of movement Cloud.
public class CloudMove : MonoBehaviour
{
    public float deltaX ;
    public float deltaY ;
    public float speed ;
    private Vector3 startpos;

    void Start()
    {
        startpos = transform.position;
    }
    private void FixedUpdate()
    {
        Vector3 v = startpos;
        v.x += deltaX * Mathf.Sin(Time.time * speed);
        v.y += deltaY * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }


}
