using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLoop : MonoBehaviour
{
    public int A;
    public float xf, yf, zf;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        A++;
        if (A < 500)
        {
            //當達到最右邊時的最遠距離
            transform.position = new Vector3(transform.position.x + xf * Time.deltaTime, transform.position.y + yf * Time.deltaTime, transform.position.z + zf * Time.deltaTime);
        }

        // 當達到最右邊時的最遠距離並且回到原點時
        if (A > 500 && A < 1000)
        {
            transform.position = new Vector3(transform.position.x - xf * Time.deltaTime, transform.position.y - yf * Time.deltaTime, transform.position.z - zf * Time.deltaTime);
        }
        if (A > 1000)
        {
            //原點繼續出去
            A = 0;
        }
    }

}
