using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jatekos : MonoBehaviour {

    float sebbeseg = 50f;
    float forgasisebbeseg = 250f;

    float kvyatmerete =0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void  Update () {

        // forgatasa

        Quaternion rot = transform.rotation;
        float z=rot.eulerAngles.z;
        z-= Input.GetAxis("Horizontal") * forgasisebbeseg * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        //fel, el mozgás

        Vector3 pos = transform.position;
        Vector3 mozgasirany = new Vector3(0,Input.GetAxis("Vertical") * sebbeseg * Time.deltaTime, 0);
        pos += rot * mozgasirany; ;

        // nem hadja el a pályát

        if (pos.y+kvyatmerete > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize- kvyatmerete;
        }

        transform.position = pos;
    }
}
