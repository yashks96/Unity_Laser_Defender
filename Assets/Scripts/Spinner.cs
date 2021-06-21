﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
	[SerializeField] float spinSpeed = 360f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
		transform.Rotate(0, 0, spinSpeed * Time.deltaTime);  
    }
}
