using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   public float speed, range;
    Vector3 fisrtpos;
    void Start()
    {
        fisrtpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Vector3.Distance(fisrtpos, transform.position) > range)
        {
            flip();
        }
     }

    void flip()
    {
        fisrtpos = transform.position;
        speed = -speed;
    }
}
