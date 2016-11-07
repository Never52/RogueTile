using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour 
{
    public float speed = 1.5f;
    private Vector3 target;
	// Use this for initialization
	void Start () 
    {
        target = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        draw();	
	}

    private void draw()
    {
        if(Input.GetMouseButton(0))//Pressed left click
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
        }
        
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

}
