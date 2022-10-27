using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float playerHealth = 100f;
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;
    public GameObject playerSkeleton;
    public GameObject explosion;

    private void Awake()
    {
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth == 0f)
        {
            playerSkeleton.SetActive(false);
            explosion.SetActive(true);
            Destroy(gameObject, 0.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BombTarget>())
        {
            playerHealth -= 100f;
        }
    }
}
