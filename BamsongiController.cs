using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{

    public float lifetime = 7.0f;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    private void Start()
    {
        //shoot(new Vector3(0, 200, 2000));
    }

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}
