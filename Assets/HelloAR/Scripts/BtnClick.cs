using UnityEngine;
using System.Collections;

public class BtnClick : MonoBehaviour {

	public float speed=100.0f;
	private GameObject gameObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (gameObj != null) {
			
			
			//gameObj.transform.Rotate(Vector3.up*Time.deltaTime*speed);
			gameObj.transform.Rotate(Vector3.up*Time.deltaTime*speed);
			
		}
	
	}

	public void btnClick(){


		gameObj = GameObject.Find ("first");





	}
}
