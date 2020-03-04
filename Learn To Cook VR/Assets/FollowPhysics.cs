using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPhysics : MonoBehaviour
{

    public Transform target;
    Rigidbody rigidbody;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(target.transform.position);
    }
}
