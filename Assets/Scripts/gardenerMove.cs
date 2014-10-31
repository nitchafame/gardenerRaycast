using UnityEngine;
using System.Collections;

public class gardenerMove : MonoBehaviour {
//	public Rigidbody walk;
//	public Vector3 direction;
//
//
//	// Use this for initialization
//	void Start () {
//		direction = new Vector3 (3f, 0f, 0f);
//		StartCoroutine ( gardenerwalk () );
//	}
//
//
//	// Update is called once per frame
//	IEnumerator gardenerwalk () {
//		while (true){
//			walk.AddForce (direction);
//
//			RaycastHit hit;
//			Ray ray = new Ray(transform.position, transform.forward);
//
//			if (Physics.Raycast(ray, out hit)){
//				transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 90f), 0f);
//				Debug.Log("RAYCAST");
//				}
//			yield return new WaitForSeconds(0.10f);
//
//			}
//
//		}
//		
//	}
//
//	void OnCollisionEnter (Collision col)
//	{
//		if (col.gameObject.name == "Cube") {
//				direction = new Vector3 (0f, 0f, 3f);
//				Debug.Log ("COLLISION");
//
//		} else {
//				direction = new Vector3 (1f, 0f, 0f);
//
//				}
//	}

	public float moveSpeed = 500f; // movement speed tuning variable
	public Rigidbody walk;
	
	// Update is called once per frame
	void Update () {
		// apply a physics force to this object's rigidbody to make it "walk"
		walk.AddForce ( transform.forward * Time.deltaTime * moveSpeed );
		
		// shoot a raycast 4 meters in front of me; if it hits something, then
		// I should randomly turn left or right
		if (Physics.Raycast ( transform.position, transform.forward, 2f ) ) {
			// Mathf.Sign returns -1 or 1 based on whether the number is negative or not
			transform.Rotate (0f, Mathf.Sign ( Random.Range (-1f, 1f) ) * 90f, 0f );
		}
		
		// visualize raycast in debug mode (scene view)
		Debug.DrawRay ( transform.position, transform.forward * 2f, Color.cyan );
	}
}


