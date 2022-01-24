using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] TrailRenderer trail;
    [SerializeField] float defaultTrailLength = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Leaf")
        {
            LengthenTail();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Poison")
        {
            ShortenTail();
            Destroy(other.gameObject);
        }
    }

    public void LengthenTail()
    {
        trail.time += 0.2f;
    }

    public void ShortenTail()
    {
        trail.time -= 0.2f;
        CheckTrailLength();
    }

    void CheckTrailLength()
    {
        if (trail.time <= 0 || trail == null)
        {
            print("Caterpillar is dead");
        }
    }
}
