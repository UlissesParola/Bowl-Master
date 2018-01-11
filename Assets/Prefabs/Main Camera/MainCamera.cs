using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Ball Ball;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = Ball.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if(Ball.transform.position.z < 16)
        {
            FollowBallPosition();
        }
        else
        {
            ZoomOut();
        }
        
    }

    void FollowBallPosition()
    {
        
        transform.SetPositionAndRotation(Ball.transform.position - offset, this.transform.rotation);
    }

    void ZoomOut()
    {
        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.01f), transform.rotation);
    }
}
