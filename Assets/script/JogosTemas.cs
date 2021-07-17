using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JogosTemas : MonoBehaviour {

	public Button inicio;
	public Button sair;
	public Button somAtivo;
	public Button somMudo;
	public Button informacao;
	public Button atencao;
	public Button EstudoUm;
	public Button AvisoDeJogo;
	public Button NovoDeJogo;
	public Button ContinuarJogo;
	public Button DeletarJogoSalvo;
	public  Text txtNomeTema;

	public string[] nomeTema;
	private int idTema;
	public Text Tema;
	public string TemaSalvo;
	public Text TemaSalvoComparacao;
	public Text informacaoJogo;
	public int somaFase;
	public string numeroTemaProximoJogo;


	public void informacaoInvisivel(){      
		informacao.gameObject.SetActive(false);
		AvisoDeJogo.gameObject.SetActive(false);

	}
	public void informacaoVisivel(){      
		informacao.gameObject.SetActive(true);
	

	}

	public void somAtivos(){      


		AudioListener.pause= true;
		somMudo.gameObject.SetActive (true);
		somAtivo.gameObject.SetActive (false);


	}
	public void somMudos(){      


		AudioListener.pause= false;
		somAtivo.gameObject.SetActive (true);
		somMudo.gameObject.SetActive (false);

	}
	public void painel(){

	}

	// Use this for initialization
	void Start () {
		somAtivo.gameObject.SetActive (true);
		informacao.gameObject.SetActive(false);

		idTema = 0;
		txtNomeTema.text = nomeTema [idTema];
		inicio.interactable = false;
		somMudo.interactable = false;


		Tema.text="T" +idTema.ToString() ;
		EstudoUm.interactable = false;

		TemaSalvo = "T" + PlayerPrefs.GetInt ("FaseSalva");
		TemaSalvoComparacao.text = TemaSalvo;

		if (PlayerPrefs.HasKey ("FaseSalva")) {

			AvisoDeJogo.gameObject.SetActive (true);
			informacaoJogo.text = "Você esta no Estudo de numero:" + PlayerPrefs.GetInt ("FaseSalva");


		} else {
			
			AvisoDeJogo.gameObject.SetActive (false);
		}
	}


	public void selecaoTemas(int i)
	{

		idTema = i;
		
		TemaSalvo = "T" + PlayerPrefs.GetInt ("FaseSalva");
		TemaSalvoComparacao.text = TemaSalvo;

		if ((numeroTemaProximoJogo== Tema.text) || (numeroTemaProximoJogo=="T0")){


			int notaFinal = 0;
			int acertos = 0;
			int erros = 0;
			float mediaAcertos = 0;
			float mediaErros = 0;
			int acertosPortugues = 0;
			txtNomeTema.text = nomeTema [i];
			EstudoUm.interactable = true;
		}
		else{
			EstudoUm.interactable = false;
		}
}
		
	public void iniciarJogo()
	{
		Application.LoadLevel ("T" +idTema.ToString());

	}
	public void sairJogo() {

		Application.Quit();
	}

	void Update () {
		
		Tema.text="T" +idTema.ToString() ;
		TemaSalvo="T" +PlayerPrefs.GetInt ("FaseSalva");


		PlayerPrefs.HasKey ("FaseSalva");
		somaFase=PlayerPrefs.GetInt ("FaseSalva");

		//somaFase = somaFase + 1;
		numeroTemaProximoJogo="T"+somaFase;


		TemaSalvoComparacao.text = TemaSalvo;

		if (PlayerPrefs.HasKey ("FaseSalva")&& PlayerPrefs.GetInt("FaseSalva")<=27) {
			informacaoJogo.text="Você esta no Estudo de numero:  " +PlayerPrefs.GetInt("FaseSalva");
		}
		else {

			informacaoJogo.text = "Parabéns! Você não tem mais estudos a fazer.";
		}
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		if ((numeroTemaProximoJogo== Tema.text) || (numeroTemaProximoJogo=="T0")) {

			EstudoUm.interactable = true;
		} else {
			EstudoUm.interactable = false;
		}


	}
}