using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullettrigger : MonoBehaviour
{
    public GameObject Shell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            GameObject bullet = Instantiate(Shell) as GameObject;
         
            bullet.GetComponent<bulletcontroller>().Shoot(new Vector3(2000, 200, 0));
        }

    }
}
