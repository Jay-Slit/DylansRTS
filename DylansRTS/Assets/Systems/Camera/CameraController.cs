using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float boundary = 10;
    
    private float speed;
    private float width;
    private float height;
    private PlayerPrefsManager playerPrefsManager;

	// Use this for initialization
	void Start () {
        width = Screen.width;
        height = Screen.height;
        speed = 50;
        //speed = PlayerPrefs.PAN_SPEED_KEY;
	}
	
	// Update is called once per frame
	void Update () {
        BorderPanning();
	}

    void BorderPanning()
    {
        if(Input.mousePosition.x > width - boundary)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.mousePosition.x < 0 + boundary)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if(Input.mousePosition.y > height - boundary)
        {
            transform.position += new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
        }
        if(Input.mousePosition.y < 0 + boundary)
        {
            transform.position -= new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
        }
    }
}
