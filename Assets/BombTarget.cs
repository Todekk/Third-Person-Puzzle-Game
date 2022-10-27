using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTarget : MonoBehaviour
{
   public GameObject bomb;
    //public MeshRenderer bomb;
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
        if (other.GetComponent<ThirdPersonShooterController>())
        {
            Destroy(bomb);
            explosion.SetActive(true);
            Destroy(gameObject, 0.5f);
        }
    }
}
