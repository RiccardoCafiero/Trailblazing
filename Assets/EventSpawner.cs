using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSpawner : MonoBehaviour
{
    [SerializeField] List<BoxCollider> availableSpots = new List<BoxCollider>();
    [SerializeField] float spawnHeight = 0.2f;
    [SerializeField] GameObject[] spawnObjects;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            foreach(Transform nephew in child)
            {
                if(nephew.TryGetComponent(out BoxCollider spot) == true)
                {
                    availableSpots.Add(spot);
                }
            }
        }

        if (availableSpots.Count > 0)
        {
            int rand = Random.Range(0, availableSpots.Count);
            GameObject eventToSpawn = spawnObjects[Random.Range(0, spawnObjects.Length)];

            Vector3 spotPos = availableSpots[rand].transform.position;
            Vector3 spawnPos = new Vector3(spotPos.x, spotPos.y + spawnHeight, spotPos.z);
            Instantiate(eventToSpawn, spawnPos, Quaternion.identity);

        }
    }

    
}
