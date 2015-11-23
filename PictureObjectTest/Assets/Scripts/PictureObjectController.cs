using UnityEngine;
using System.Collections;

public class PictureObjectController : MonoBehaviour {

	// Use this for initialization
	public Renderer rend;

	private Vector3 screenPoint;
	private Vector3 offset;

	void Start() {
		rend = GetComponent<Renderer>();
	}
//
//	void OnMouseDown()
//	{
//		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
//		
//		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
//		
//	}
	
	/*void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint)+offset;
		transform.position = curPosition;
		
	}*/
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			// Get movement of the finger since last frame
			Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			
			// Move object across XY plane
			transform.Translate(touchDeltaPosition.x ,0.0f , touchDeltaPosition.y);
			//Vector3 movement = new Vector3(-touchDeltaPosition.x * speed, 0.0f, -touchDeltaPosition.y * speed);
			//rb.AddForce(movement*speed);
		}

	
	}


}
