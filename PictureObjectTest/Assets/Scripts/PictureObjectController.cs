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

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		
	}
	
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint)+offset;
		transform.position = curPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
