using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivation : MonoBehaviour
{
    public GameObject active;
    public GameObject inactive;
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
            active.SetActive(true);
            inactive.SetActive(false);
        }
        
    }
}
