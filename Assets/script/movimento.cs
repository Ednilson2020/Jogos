using UnityEngine;
using System.Collections;

public class movimento : MonoBehaviour {
	
	private Material materialAtual;
	public float velocidadeMovimento;
	private float offset;



	// Use this for initialization
	void Start () {

		materialAtual = GetComponent<Renderer> ().material;
	
	}
	
	// Update is called once per frame
	void Update () {
		offset += 0.001f;
		materialAtual.SetTextureOffset ("_MainTex", new Vector2 (offset * velocidadeMovimento, 0));
	}
}
