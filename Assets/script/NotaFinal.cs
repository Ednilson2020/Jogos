using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NotaFinal : MonoBehaviour {

	private int idTema;
	public Text txtNota;
	public Text txtInfotema;

	public Text questoes;
	public Text media;
	public Text pontuacao;
	public Text Aprovado;
	public Text Reprovado;
	public Text Pagina;
	public Text EstudoTema;
	public Text NumeroTema;
	public Text profissoes;

	public string[] PaginaContador;

	private float notafinal;
	private float notaFinalP;
	private int acertos;
	private int erros;

	private int A=0;
	private int B=0;
	private int C=0;
	private int D=0;
	private int E=0;

	private int idTipos=0;
	public Text tipos;
	public string[] tiposPersonalidades;
    public string[] InglesTiposPersonalidades;

    private int somatotal=0;


	private int Questoes;

	private int Paginas;
	private int numeroTema;

	private float mediaP;
	private float Media;

	public string nomeCena;

	public Text informacaoJogo;

	public Button salvar;

	public Button profissao;
	public Button profissaoEsconder;

	public Button profissaoDois;
	public Button profissaoEsconderDois;

	public Button profissaoTres;
	public Button profissaoEsconderTres;

	public Button profissaoQuatro;
	public Button profissaoEsconderQuatro;

	public Image tipo1;
	public Image tipo2;
	public Image tipo3;
	public Image tipo4;
    public Image tipo5;
    public Image tipo6;
    public Image tipo7;
    public Image tipo8;

    public Image simAmor;
	public Image simPaixao;
	public Image simAmizade;
	public Image simNamoro;

	public Image profissao1;
	public Image profissao2;
	public Image profissao3;
	public Image profissao4;

	private int amor;
	private int amizade;
	private int paixao;
	private int indeciso;
	private int naoGosta;
	private int vcAma;
	private int cuidado;
	private int conhecer;
	private int compativel;
    public Text amorResult;

    private AdmobManager publicidade;
    public void painelProfiisaoVisivel(){
		profissao1.gameObject.SetActive (true);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);

		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (true);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);


		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisaoInVisivel(){
		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);

		profissaoEsconder.gameObject.SetActive (false);
		profissao.gameObject.SetActive (true);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);


		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisao2Visivel(){
		profissao2.gameObject.SetActive (true);
		profissao1.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);

		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);

		profissaoEsconderDois.gameObject.SetActive (true);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisao2InVisivel(){
		profissao2.gameObject.SetActive (false);
		profissao1.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);

		profissaoEsconder.gameObject.SetActive (false);
	

		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);


		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (true);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisao3Visivel(){
		profissao3.gameObject.SetActive (true);
		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);


		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (true);

		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisao3InVisivel(){

		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);
		profissao.gameObject.SetActive (false);

		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (true);
		profissaoEsconderTres.gameObject.SetActive (false);


		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}
	public void painelProfiisao4Visivel(){
		profissao4.gameObject.SetActive (true);
		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);

		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);


		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (true);

	}
	public void painelProfiisao4InVisivel(){
		profissao4.gameObject.SetActive (false);
		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);
		profissao.gameObject.SetActive (false);


		profissao.gameObject.SetActive (false);
		profissaoEsconder.gameObject.SetActive (false);

		profissaoTres.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);

		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoDois.gameObject.SetActive (false);

		profissaoQuatro.gameObject.SetActive (true);
		profissaoEsconderQuatro.gameObject.SetActive (false);

	}

	// Use this for initialization
	void Start () {

        publicidade = FindObjectOfType<AdmobManager>() as AdmobManager;
        publicidade.MostrarVideo();

		tipo1.gameObject.SetActive(false);
		tipo2.gameObject.SetActive(false);
		tipo3.gameObject.SetActive(false);
		tipo4.gameObject.SetActive(false);

		simAmor.gameObject.SetActive(false);
		simAmizade.gameObject.SetActive(false);
		simNamoro.gameObject.SetActive(false);
		simPaixao.gameObject.SetActive(false);

		profissao.gameObject.SetActive (false);
		profissao1.gameObject.SetActive (false);
		profissao2.gameObject.SetActive (false);
		profissao3.gameObject.SetActive (false);
		profissao4.gameObject.SetActive (false);

		profissaoEsconder.gameObject.SetActive (false);

		profissaoDois.gameObject.SetActive (false);
		profissaoTres.gameObject.SetActive (false);
		profissaoQuatro.gameObject.SetActive (false);

		profissaoEsconderDois.gameObject.SetActive (false);
		profissaoEsconderTres.gameObject.SetActive (false);
		profissaoEsconderQuatro.gameObject.SetActive (false);

		idTipos = 0;

		tipos.text = tiposPersonalidades [idTipos];

		idTema = PlayerPrefs.GetInt("idTema");
		amor = PlayerPrefs.GetInt("Amor");
		amizade = PlayerPrefs.GetInt("Amizade");
		paixao = PlayerPrefs.GetInt("Paixao");
		indeciso = PlayerPrefs.GetInt("Indeciso");
		naoGosta = PlayerPrefs.GetInt("naoGosta");
		vcAma = PlayerPrefs.GetInt("VcAma");
		cuidado = PlayerPrefs.GetInt("Cuidado");
		conhecer = PlayerPrefs.GetInt("Conhecer");
		compativel = PlayerPrefs.GetInt("Compativel");

	
		numeroTema = PlayerPrefs.GetInt ("idTema");
		NumeroTema.text = numeroTema.ToString ();
      
      
	}
	public void proximoEstudo(){

		Application.LoadLevel ("T" +numeroTema);
	}
	public void salvarNivelDoJogo(){
		
		numeroTema += 1;
		PlayerPrefs.SetInt ("FaseSalva", numeroTema);

		Application.LoadLevel ("T" +numeroTema);
	}
	
	void proximaPergunta ()
	{

		idTipos+= 1;
	}

    void Update()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        amor = PlayerPrefs.GetInt("Amor");
        amizade = PlayerPrefs.GetInt("Amizade");
        paixao = PlayerPrefs.GetInt("Paixao");
        indeciso = PlayerPrefs.GetInt("Indeciso");
        naoGosta = PlayerPrefs.GetInt("naoGosta");
        vcAma = PlayerPrefs.GetInt("VcAma");
        cuidado = PlayerPrefs.GetInt("Cuidado");
        conhecer = PlayerPrefs.GetInt("Conhecer");
        compativel = PlayerPrefs.GetInt("Compativel");

        if (amor > amizade && amor > paixao && amor > indeciso && amor > naoGosta)
        {
            tipo3.gameObject.SetActive(true);
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {


                amorResult.text = "Amor";
              //  tipos.text = tiposPersonalidades[0] + ". Vocês têm muita chances de serem felizes. Os dois têm personalidades compatíveis. Um futuro relacionamento pode dar certo. ";
              //  tipo3.gameObject.SetActive(true);
            }
            else
            {
                
                amorResult.text = "Love";
             //   tipos.text = InglesTiposPersonalidades[0] + ". You have a good chance of being happy. Both have compatible personalities. A future relationship can work.";
            //    tipo3.gameObject.SetActive(true);
            }
            //  tipo3.gameObject.SetActive(true);



            ////tipos.text = tiposPersonalidades [0];
            if (compativel == 1)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    tipos.text = tiposPersonalidades[0] + ". Vocês têm muita chances de serem felizes. Os dois têm personalidades compatíveis. Um futuro relacionamento pode dar certo. ";

                }
                else
                {
                    tipos.text = InglesTiposPersonalidades[0] + ". You have a good chance of being happy. Both have compatible personalities. A future relationship can work.";

                }

            }
            if (compativel == 0)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    tipos.text = tiposPersonalidades[0] + " . Há amor, porém, cabe reflitir se você deseja ter um relacionamento como essa pessoa " +
                     "Ele tem personalidade diferente da sua. Um futuro relacionamento pode não dar certo.";
                }
                else
                {
                    tipos.text = InglesTiposPersonalidades[0] + ". There is love, however, it is worth reflecting if you want to have a relationship like that person "+
                     "He has a personality different from yours. A future relationship may not work."; //
                }

            }
            if (vcAma > 1)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    tipos.text = tiposPersonalidades[0] + " . A pessoa ama você e parece que você também ama essa pessoa, porém, cabe reflitir se você deseja ter um relacionamento. " +
                   "Essa pessoa tem personalidade diferente da sua. Pode ser um relacionamento difícil e conturbado.";

                }
                else
                {
                    tipos.text = InglesTiposPersonalidades[0] + " .The person loves you and it seems that you also love that person, but it is worth reflecting if you want to have a relationship. " +
                   "This person has a personality different from yours. It can be a difficult and troubled relationship."; //
                }

            }
            else
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    tipos.text = tiposPersonalidades[0] + " . A pessoa ama você e parece que você também ama essa pessoa, porém, cabe reflitir se você deseja ter um relacionamento. " +
                   "Essa pessoa tem personalidade diferente da sua. Pode ser um relacionamento difícil e conturbado.";

                }
                else
                {
                    tipos.text = InglesTiposPersonalidades[0] + " .The person loves you and it seems that you also love that person, but it is worth reflecting if you want to have a relationship. " +
                   "This person has a personality different from yours. It can be a difficult and troubled relationship."; //
                }

            }

        }
        if (amizade > amor && amizade > paixao && amizade > indeciso && amizade > naoGosta)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
                amorResult.text = "Amizade";
                tipos.text = tiposPersonalidades[3];
            }
            else
            {
                Aprovado.text = "he just wants to be a friend!";
                tipos.text = InglesTiposPersonalidades[3];         
                amorResult.text = "Friendship";
               

            }
            // Aprovado.text = "ele quer ser apenas  amigo ! ";
            tipo4.gameObject.SetActive(true);
           
         


        }
         if (paixao > amor && paixao > amizade && paixao > indeciso && paixao > naoGosta)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
                amorResult.text = "Paixão";
                profissaoTres.gameObject.SetActive(true);
                tipos.text = tiposPersonalidades[2];
            }
            else
            {
                Aprovado.text = "he is in love! ";
                profissaoTres.gameObject.SetActive(true);
                tipos.text = InglesTiposPersonalidades[2];
                amorResult.text = "Passion";
            }

            tipo6.gameObject.SetActive(true);
            simPaixao.gameObject.SetActive(true);
          //  profissaoDois.gameObject.SetActive(true);


        }
        if (indeciso > amor && indeciso > paixao && indeciso > amizade && indeciso > naoGosta)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
                Aprovado.text = "Ele está indeciso quanto aos seus sentimentos ";
                //tipo4.gameObject.SetActive(true);
                profissaoQuatro.gameObject.SetActive(true);
                tipos.text = tiposPersonalidades[1];
            }
            else
            {
                Aprovado.text = "He's undecided about his feelings";
                //tipo4.gameObject.SetActive(true);
                profissaoQuatro.gameObject.SetActive(true);
                tipos.text = InglesTiposPersonalidades[1];
            }
            tipo7.gameObject.SetActive(true);


        }
      //  amizade > amor && amizade > paixao && amizade > indeciso && amizade > naoGosta
        if (naoGosta > amizade && naoGosta > paixao && naoGosta > indeciso && naoGosta > amor)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
                //  Aprovado.text = "ele quer ser apenas  amigo ! ";
                amorResult.text = "Não gosta!";
                tipos.text = tiposPersonalidades[4];
                tipo8.gameObject.SetActive(true);
            }
            else
            {
               // Aprovado.text = "he just wants to be a friend!";
              

                amorResult.text = "Do not like";
                tipos.text = InglesTiposPersonalidades[4];
                tipo8.gameObject.SetActive(true);
              

            }
            // Aprovado.text = "ele quer ser apenas  amigo ! ";
            tipo8.gameObject.SetActive(true);
          
          //  profissaoDois.gameObject.SetActive(true);
            //	tipos.text = tiposPersonalidades [1];



        }
        //else
        //{
        //    Aprovado.text = "Null ";
        //    profissao.gameObject.SetActive(false);
        //}
        idTema = PlayerPrefs.GetInt("idTema");

        numeroTema = PlayerPrefs.GetInt("NumeroTemaTemp" + idTema.ToString());
        NumeroTema.text = numeroTema.ToString();

    }
}