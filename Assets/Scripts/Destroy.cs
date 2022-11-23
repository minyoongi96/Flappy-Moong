using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject tree;
    // Update is called once per frame
    void Update()
    {
        Destroy(tree, 15);
    }
}
