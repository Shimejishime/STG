﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiki : MonoBehaviour {
   
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(0.1f, 0, 0);
        }
		
	}
}
