using UnityEngine;
using System.Collections;

public class Planeta : MonoBehaviour {
	public GameObject center;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//Permitee girar un objeto alrededor de otro
	//Lo busque en google como: rotate around unity
		transform.RotateAround (center.transform.position , Vector3.up, speed * Time.deltaTime);
	}
}
