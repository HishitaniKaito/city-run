using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float n;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        n +=2;
        this.gameObject.transform.rotation = Quaternion.Euler(transform.rotation.x,n,transform.rotation.z);
    }
}
