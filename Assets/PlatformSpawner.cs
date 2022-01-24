using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] platformList;
    [SerializeField] float platformDistance = 2f;
    [SerializeField] bool randomOrder = false;

    int platform = -1;

    public void CreateNewPlatform(Vector3 pos)
    {
        
        if (randomOrder)
        {
            platform = Random.Range(0, platformList.Length);
        }
        else
        {
            platform += 1;
        }
        
        GameObject newPlatform = Instantiate(
            platformList[platform], 
            new Vector3(pos.x + platformDistance, pos.y, pos.z), 
            Quaternion.identity, 
            this.transform);
    }
}
