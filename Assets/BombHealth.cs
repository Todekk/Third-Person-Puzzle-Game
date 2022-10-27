using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHealth : MonoBehaviour
{
    public GameObject bombBody;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletProjectile>())
        {
            explosion.SetActive(true);
            Destroy(bombBody, 0.5f);
        }
    }
}
