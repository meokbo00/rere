using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rigidbody;
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
        this.rigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        
    }
}
