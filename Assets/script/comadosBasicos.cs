using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comadosBasicos : MonoBehaviour {

	public Button sair;
	public string nomeCena;

	public void LoadScene(string name)
	{
		nomeCena = name;
		StartCoroutine ("Abrir");


	}

	private IEnumerator Abrir(){
		yield return new WaitForSeconds (0.5f);
		Application.LoadLevel (nomeCena);
	}

	public void resetamentoPontos()
	{
		PlayerPrefs.DeleteAll ();
	}


}