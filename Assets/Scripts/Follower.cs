using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject objectToFollow;
    [SerializeField] float followingDistance = 40f;

    //Follow the player if there is no other object to follow
    // Start is called before the first frame update
    void Start()
    {
        if(objectToFollow == null)
        {
            objectToFollow = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(objectToFollow.transform.position.x + followingDistance, 0f, 0f);
    }
}
