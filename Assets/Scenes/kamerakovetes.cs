using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakovetes : MonoBehaviour {

    public Transform jatekos;
	
	// Update is called once per frame
	void Update () {

        if (jatekos !=null)
        {
             Vector3 elhelyezkedes = jatekos.position;
            elhelyezkedes.z = transform.position.z;
            transform.position = elhelyezkedes;
        }
	}
}
