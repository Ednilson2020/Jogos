using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class quem : MonoBehaviour {
	private int idTema;
	public int Numero;

	public Image PanelMenuBaixo;

	public List<int>lista = new List<int>();

	public System.Random ran = new System.Random();//sorteia aleatoriamente


	public int X=0;
	public Text pergunta;
	public Text respostaA;
	public Text respostaB;

	public Text disciplinas;
	public Text sabermais;

	public Text infoRespostas;
	public Text respostaCerta;

	public Button proxima;
	public Button btnRespostaA;
	public Button btnRespostaB;

	public Sprite acertou;
	public Button Detalhes;
	public Button Detalhes1;
	public Button Detalhes2;
	public Button Detalhes3;
	public Button Titulo;
	public Button sabe;


	public string[] perguntas;// cria um banco de dados.
	public string[] alternativaA;
	public string[] alternativaB;


	public string[] saberM;
	public string[] corretas;
	public string[] diciplinas;
	public string[] alternativaDisciplina;
	public string[] mostraDisciplina;
	public string[] acumaladorAlt;

	private int idPergunta;
	private int idPerguntaAcumulador;

	public int NumeroTema;

	public int acertos;
	public int erros;

	//soma das respostas
	public int somaA=0;
	public int somaB=0;


	public int questoes;
	public float media;
	public  int notaFinal;
	public float mediaP;
	public  float notaFinalP;


	public Material[] material;
	Renderer rend;

	// audio
	public AudioSource audio;
	public AudioClip certo;
	public AudioClip errado;
	public AudioClip click;


	public Button MenuVisivel;
	public Button MenuInvisivel;

    private Tradutor tradutor;


	public void disableAllButtons(){      
		Detalhes.gameObject.SetActive(false);
		Detalhes1.gameObject.SetActive(false);
		Detalhes2.gameObject.SetActive(false);
		Detalhes3.gameObject.SetActive(false);

	}
	public void enableAllButtons(){      
		Detalhes.gameObject.SetActive(true);
		Detalhes1.gameObject.SetActive(true);
		Detalhes2.gameObject.SetActive(true);
		Detalhes3.gameObject.SetActive(true);

	}



	public void saber(){      
		sabe.gameObject.SetActive(false);
		Titulo.gameObject.SetActive(false);

	}
	public void saberVisivel(){      
		sabe.gameObject.SetActive(true);
		Titulo.gameObject.SetActive(false);

	}

	public void VisivelMenu(){      


		PanelMenuBaixo.transform.localScale = new Vector2 (10.0f, 1.0f);
		MenuVisivel.gameObject.SetActive(false);
		MenuInvisivel.gameObject.SetActive(true);

	}
	public void InvisivelMenu(){      
		PanelMenuBaixo.transform.localScale = new Vector2(1.0F, 1);
		MenuVisivel.gameObject.SetActive(true);
		MenuInvisivel.gameObject.SetActive(false);
	}

	// Use this for initialization
	void Start () {
        tradutor = FindObjectOfType<Tradutor>() as Tradutor;
		idPergunta = 0;
		questoes = perguntas.Length;
		idTema = PlayerPrefs.GetInt("idTema");

		btnRespostaA.interactable = true;
		btnRespostaB.interactable = true;

		Detalhes.interactable = false;
		proxima.interactable= false;

	


		respostaCerta.text = "";


		pergunta.text = perguntas [idPergunta];
		respostaA.text = alternativaA [idPergunta];
		respostaB.text = alternativaB [idPergunta];
	
		//respostaE.text = alternativaE [idPergunta];
		disciplinas.text = alternativaDisciplina [idPergunta];
		sabermais.text = saberM [idPergunta];



	}

	public void respostas (string alternativa)
	{

		if (alternativa== "A") {
			audio.PlayOneShot (click);
			somaA += 1;

			btnRespostaA.interactable = false;
			btnRespostaB.interactable = false;
			proxima.interactable = true;

		} 
		else if (alternativa== "B") {
			audio.PlayOneShot (click);
			somaB += 1;

			btnRespostaA.interactable = false;
			btnRespostaB.interactable = false;

			proxima.interactable = true;

		}


		if (alternativa == "OK") {

			proximaPergunta ();

		}


	}
	void proximaPergunta ()
	{

		idPergunta += 1;


		if (idPergunta <= (questoes-1)) 
		{

			btnRespostaA.interactable = true;
			btnRespostaB.interactable = true;
			proxima.interactable = false;
			Detalhes.interactable = false;


			respostaCerta.text = "";

			pergunta.text = perguntas [idPergunta];
			respostaA.text = alternativaA [idPergunta];
			respostaB.text = alternativaB [idPergunta];

			sabermais.text = saberM [idPergunta];

            tradutor.idQuem = idPergunta;

		} 
		else 
		{
			
			PlayerPrefs.SetFloat ("notaFinalTemp" + idTema.ToString (), media);
			PlayerPrefs.SetInt ("acertosTemp" + idTema.ToString (), acertos);
			PlayerPrefs.SetInt ("errosTemp" + idTema.ToString (), erros);

			PlayerPrefs.SetInt ("Atemp" + idTema.ToString (),  somaA);
			PlayerPrefs.SetInt ("Btemp" + idTema.ToString (),  somaB);

			PlayerPrefs.SetInt ("questoesTemp" + idTema.ToString (), questoes);
			PlayerPrefs.SetFloat ("mediaTemp" + idTema.ToString (),  mediaP);

			//PlayerPrefs.SetFloat ("ResultadoTemp" + idTema.ToString (),  resultadoTeste);

		
			PlayerPrefs.SetInt ("NumeroTemaTemp" + idTema.ToString (), NumeroTema);



			Application.LoadLevel ("queroSaber");
		}

	}

	void Update () {

		questoes = perguntas.Length;
	
	//	pergunta.text = perguntas [idPergunta];
		//respostaA.text = alternativaA [idPergunta];
		//respostaB.text = alternativaB [idPergunta];
        tradutor.idQuem = idPergunta;
    }

}
