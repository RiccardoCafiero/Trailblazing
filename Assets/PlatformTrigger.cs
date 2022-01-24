using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    PlatformSpawner platformSpawner;
    private void Start()
    {
        platformSpawner = GameObject.FindObjectOfType<PlatformSpawner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EndPoint")
        {
            print("platform endpoint has been reached, creating new platform");
            platformSpawner.CreateNewPlatform(transform.position);
        }
    }
}
