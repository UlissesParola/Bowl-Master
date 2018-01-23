using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 Force;

    private Rigidbody _ballRigidbody;
    private AudioSource _audioSource;

	// Use this for initialization
	void Start ()
    {
        _audioSource = GetComponent<AudioSource>();
        _ballRigidbody = GetComponent<Rigidbody>();

        _ballRigidbody.useGravity = false;

        //Launch(Force);
    }

    public void Launch(Vector3 force)
    {
        _ballRigidbody.useGravity = true;
        _ballRigidbody.AddForce(force, ForceMode.Impulse);
        _audioSource.Play();
    }

}
