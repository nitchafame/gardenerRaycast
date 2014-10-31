//using UnityEngine;
//using System.Collections;
//
//public class gardenerPlantWall : MonoBehaviour {
//	public Transform wallPrefab;
//	// Use this for initialization
//	void Start () {
//		StartCoroutine ( gardenerwall () );
//	}
//	
//	// Update is called once per frame
//	IEnumerator gardenerwall () {
//		while (true){
//			if (transform.right return true) {
//			Instantiate ( wallPrefab, transform.position, Quaternion.identity );
//		
////		} else {
////			(Physics.Raycast ( transform.position, transform.left, 1f ) ) {
////			Instantiate ( wallPrefab, transform.position, Quaternion.identity );
////			
//			}
//				yield return new WaitForSeconds(0.50f);
//		// visualize raycast in debug mode (scene view)
//		Debug.DrawRay ( transform.position, transform.forward * 2f, Color.yellow );
//		}
//	}
//}
