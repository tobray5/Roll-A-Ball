using UnityEngine;
using System.Collections;

public class Trail : MonoBehaviour {

    private ParticleSystem ps;

    public float lifetime = 0.1f;
    public float lengthmodifier = 0.1f;

    // Use this for initialization
    void Start () {
        ps = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void  Upgrade() {
        lifetime = lifetime + lengthmodifier;
        ps.startLifetime = lifetime;
    }
}
