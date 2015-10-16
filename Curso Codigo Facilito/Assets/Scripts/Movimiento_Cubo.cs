using UnityEngine;
using System.Collections;

public class Movimiento_Cubo : MonoBehaviour {

	float var_rotacion = 30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


	}

	void Rotar()
	{
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate (new Vector3 (0f, 30f, 0f) * Time.deltaTime);
	}

}
