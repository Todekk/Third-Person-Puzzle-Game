using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    public float timer = 3f;
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    private Rigidbody bulletRigidbody;
    // Start is called before the first frame update

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        float speed = 30f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {        
        if (other.GetComponent < PlayerHealth>() != null)
        {            
                Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
                Destroy(gameObject);           

        }
        if (other.GetComponent<BombTarget>())
        {

        }
        else
        {
            Instantiate(vfxHitRed, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
