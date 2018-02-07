using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	public float StandingThreshold = 10f;

	private AudioSource audioSource;
	// Use this for initialization
	void Start ()
	{
	    audioSource = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name != "Floor")
        {
            audioSource.Play();
        }
        
    }

	public bool IsStanding()
	{
		Vector3 pinAngles = transform.rotation.eulerAngles;



		float tiltZ = (pinAngles.z > 180) ? pinAngles.z - 360 : pinAngles.z;
		tiltZ = Mathf.Abs(tiltZ);

		float tiltX = (pinAngles.x > 180) ? pinAngles.x - 360 : pinAngles.x;
		tiltX = Mathf.Abs(tiltX);


		if (tiltZ > StandingThreshold || tiltX > StandingThreshold)
		{
			return false;
		}

		return true;

	}

    // Update is called once per frame
	void Update () {

	}
}
