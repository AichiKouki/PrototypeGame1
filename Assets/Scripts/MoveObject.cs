using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
       
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += new Vector3(0.1f * Controller.gameSpeed, 0.0f ,0.0f);

        if(this.transform.position.x > 100.0f)
        {
            Destroy(this.gameObject);
        }

	}
}
