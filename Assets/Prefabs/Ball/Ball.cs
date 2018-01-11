using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float Force;

    private Rigidbody _ballRigidbody;
    private AudioSource _audioSource;

	// Use this for initialization
	void Start ()
    {
        _audioSource = GetComponent<AudioSource>();
        _ballRigidbody = GetComponent<Rigidbody>();

        Launch();
    }

    private void Launch()
    {
        Vector3 newForce = new Vector3(0f, 0f, Force);
        _ballRigidbody.AddForce(newForce, ForceMode.Impulse);
        _audioSource.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
