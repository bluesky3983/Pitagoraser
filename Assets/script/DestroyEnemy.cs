using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {
	public GameObject counter;
	public AudioClip enemy_down;
	AudioSource audioSource;
	private GameObject deathParticle;
	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("DeathCounter");
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = enemy_down;
		deathParticle = Resources.Load ("DeathEnemy") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody.WakeUp ();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			//Debug.Log("ok");
			Destroy(col.gameObject);
			audioSource.Play();
			Count script = counter.GetComponent<Count>();
			script.DestroyCount++;
			GameObject particle = Instantiate(deathParticle ,new Vector3(col.transform.position.x,col.transform.position.y,col.transform.position.z), col.transform.rotation ) as GameObject;
			Destroy(particle, 0.5f);
		}
	}
}
