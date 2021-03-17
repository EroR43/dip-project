using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatSwap : MonoBehaviour
{
    public Material[] mats;
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
    }

    void SwapMat()
    {
        obj.GetComponent<MeshRenderer>().materials[1] = mats[1];
        System.Array.Reverse(mats);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            SwapMat();
        }
    }
}
