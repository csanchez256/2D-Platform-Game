/* Note: this code is from Unity's tutorials page. I'm using it for
 * self learning **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {

    public float fallDelay = 1;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            rb2d.isKinematic = false;
    }
}
