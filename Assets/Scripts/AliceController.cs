using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class AliceController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0; 
        //Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //UnityEngine.Debug.Log(horizontal);
        Vector2 position = transform.position;

        var x = (position.x + 10f * horizontal * Time.deltaTime);
        var y = (position.y + 10f * vertical * Time.deltaTime);


        position.x = x>10?10:(x<-10?-10:x);
        position.y = y>10?10:(y<-10?-10:y);
        
        UnityEngine.Debug.Log(Time.deltaTime);
        transform.position = position;
    }
}
