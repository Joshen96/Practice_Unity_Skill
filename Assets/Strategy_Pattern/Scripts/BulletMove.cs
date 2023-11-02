using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField]
    float speed =10f;

    

    private void Update()
    {
        this.transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(this.transform.position.y>10f)
        {

            Destroy(this.gameObject);
        }
    }

}
