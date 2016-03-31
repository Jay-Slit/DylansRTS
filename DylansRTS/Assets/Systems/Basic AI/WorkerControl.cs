using UnityEngine;
using System.Collections;

public class WorkerControl : MonoBehaviour {

    public float speed;
    private bool isSelected;

    private Vector3 pos;
    private Vector3 mPos;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mPos = Input.mousePosition;
        mPos = new Vector3(mPos.x, mPos.y, transform.position.y);
        pos = GetComponent<Camera>().ScreenToWorldPoint(mPos);

        if (isSelected) {
            IssueCommands();
        }
	}

    void IssueCommands()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = new Ray(new Vector3(pos.x, 0, pos.y), Vector3.down);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.collider.tag == "resource")
                {
                    MoveTo(hit.collider.transform.position);
                }
            }

        }
    }

    void MoveTo(Vector3 target)
    {
        transform.position = Vector3.Lerp(transform.position, target, speed);
    }
}
