using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> laserObjs;
    //Transform laserOrigin;

    [SerializeField]
    private float cellChrg;
    [SerializeField]
    private float laserSpd;

    private Transform origTransform;


    private void Awake()
    {
        foreach (GameObject las in GameObject.FindGameObjectsWithTag("Laser"))
        {
            laserObjs.Add(las);
        }
        origTransform = laserObjs[0].transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Shoot();
    }

    void Shoot()
    {
        //if(cellChrg > 1)
        //{
        //    if(Input.GetMouseButton(0) != false)
        //    {
        //        Vector3 scale = new Vector3();
        //        scale.z = 1 * Time.deltaTime;
        //        laserObj.transform.localScale += scale;
        //    }
        //    else if(Input.GetMouseButtonUp(0) == true)
        //    {
        //        for (float tarPOS = 30; laserObj.transform.position.z < tarPOS;)
        //        {
        //            Vector3 pos = new Vector3();
        //            pos.z = 1 * Time.deltaTime;
        //            laserObj.transform.position += pos;
        //        }
        //    }
        //}
    }
}
