using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
	public Transform target;

    public Tilemap map;

    private Vector3 bottomleft;
    private Vector3 topright;

    private float halfHeight;
    private float halfWidth;

    // Start is called before the first frame update
    void Start()
    {
        //target = PlayerControler.instance.transform;

        target = FindObjectOfType<PlayerControler>().transform;

        halfHeight = Camera.main.orthographicSize;

        halfWidth = halfHeight * Camera.main.aspect;

        bottomleft = map.localBounds.min + new Vector3 ( halfWidth+1, halfHeight+2.1f,0f);


        topright = map.localBounds.max + new Vector3(-halfWidth-1,-halfHeight-2.1f,0f);


        //PlayerControler.instance.SetBounds(map.localBounds.min, map.localBounds.max);
    }

    // Update is called once per frame
    void Update()
    {
        
    	transform.position = new Vector3(target.transform.position.x,target.transform.position.y,transform.position.z);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x,bottomleft.x,topright.x), Mathf.Clamp(transform.position.y, bottomleft.y, topright.y),transform.position.z);
    }
}
