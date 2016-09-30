using UnityEngine;
using System.Collections;

public class Bal : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("OVRPlayerController"))
        {
            Captured();
        }
    }

    void Captured()
    {
        var world = GameObject.FindGameObjectWithTag("World");
        if (world != null)
        {
            world.BroadcastMessage("AddItem");
            Destroy(gameObject);
        }
    }
}
