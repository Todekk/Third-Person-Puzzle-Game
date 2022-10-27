using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    public float timer = 5f;
    [SerializeField] private Transform bulletPrefab;
    [SerializeField] private Transform spawnBulletPosition;
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
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 mouseWorldPosition = Vector3.zero;
        Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized;
        Instantiate(bulletPrefab, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
        timer = 3f;
        }
    }
    
}
