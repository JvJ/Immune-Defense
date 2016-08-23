using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        
        if (Physics.Raycast(ray, out hitInfo))
        {
            transform.position = hitInfo.point;
            var mesh = this.GetComponent<MeshRenderer>();
            mesh.material.color = new Color(hitInfo.normal.x, hitInfo.normal.y, hitInfo.normal.z);
        }
	}
}
