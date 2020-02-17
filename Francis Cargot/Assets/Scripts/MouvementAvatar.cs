﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementAvatar : MonoBehaviour
{

    public float mouvementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + mouvementSpeed * Time.deltaTime);
    }
}