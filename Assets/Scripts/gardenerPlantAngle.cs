//using UnityEngine;
//using System.Collections;
//
//public class gardenerPlantAngle : MonoBehaviour {
//	public Transform treePrefab; // assign in inspector
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Physics.Raycast (transform.eulerAngles.y - transform.eulerAngles.y > 15f ) ) {
//			Instantiate ( treePrefab, transform.position, Quaternion.identity );
//			
//
//		}
//
//		// visualize raycast in debug mode (scene view)
//		Debug.DrawRay ( transform.position, transform.forward * 2f, Color.yellow );
//	}
//}