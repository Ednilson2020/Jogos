using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ControleRespostaEle : MonoBehaviour {

    private int idTema;
    public int Numero;
    public int idTela;

    public Image PanelMenuBaixo;

    public List<int> lista = new List<int>();

    public System.Random ran = new System.Random();//sorteia aleatoriamente

    public int amor = 0;
    public int amizade = 0;
    public int paixao = 0;
    public int indeciso = 0;
    public int naoGosta = 0;
    public int vcAma = 0;
    public int cuidado = 0;
    public int conhecer = 0;
    public int personalidadeDele;
    public int personalidadeDela;
    public bool personalidade;
    public int compativel;

    public int X = 0;
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text respostaE;

    public Text disciplinas;
    public Text sabermais;

    public Text infoRespostas;
    public Text respostaCerta;

    public Button proxima;
    public Button btnRespostaA;
    public Button btnRespostaB;
    public Button btnRespostaC;
    public Button btnRespostaD;
    public Button btnRespostaE;
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
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] alternativaE;

    public string[] saberM;
    public string[] IngleSaberM;
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
    public int somaA = 0;
    public int somaB = 0;
    public int somaC = 0;
    public int somaD = 0;
    public int somaE = 0;

    public int somaPortugues;
    public int somaMatematica;
    public int somaQuimica;
    public int somaBiologia;
    public int somaHistoria;
    public int somaLiteratura;
    public int somaFisica;

    public int questoes;
    public float media;
    public int notaFinal;
    public float mediaP;
    public float notaFinalP;


    public Material[] material;
    Renderer rend;

    // audio
    public AudioSource audio;
    public AudioClip certo;
    public AudioClip errado;
    public AudioClip click;


    public Button MenuVisivel;
    public Button MenuInvisivel;

    public Image anim1;

    public Image anjoUm;
    public Image anjoDois;


    public void disableAllButtons()
    {
        Detalhes.gameObject.SetActive(false);
        Detalhes1.gameObject.SetActive(false);
        Detalhes2.gameObject.SetActive(false);
        Detalhes3.gameObject.SetActive(false);

    }
    public void enableAllButtons()
    {
        Detalhes.gameObject.SetActive(true);
        Detalhes1.gameObject.SetActive(true);
        Detalhes2.gameObject.SetActive(true);
        Detalhes3.gameObject.SetActive(true);

    }



    public void saber()
    {
        sabe.gameObject.SetActive(false);
        Titulo.gameObject.SetActive(false);


    }
    public void saberVisivel()
    {
        sabe.gameObject.SetActive(true);
        Titulo.gameObject.SetActive(false);

    }

    public void VisivelMenu()
    {


        PanelMenuBaixo.transform.localScale = new Vector2(10.0f, 1.0f);
        MenuVisivel.gameObject.SetActive(false);
        MenuInvisivel.gameObject.SetActive(true);

    }
    public void InvisivelMenu()
    {
        PanelMenuBaixo.transform.localScale = new Vector2(1.0F, 1);
        MenuVisivel.gameObject.SetActive(true);
        MenuInvisivel.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {



        Detalhes.interactable = false;
        Detalhes1.interactable = false;
        Detalhes2.interactable = false;
        Detalhes3.interactable = false;

        sabe.gameObject.SetActive(false);
        anjoDois.gameObject.SetActive(false);


        idTema = PlayerPrefs.GetInt("idTema");

        idPergunta = 0;
        somaPortugues = 0;

        respostaCerta.text = "";
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];
        //respostaE.text = alternativaE [idPergunta];
        disciplinas.text = alternativaDisciplina[idPergunta];
        sabermais.text = saberM[idPergunta];


        infoRespostas.text = "Respondendo " + (idTema + 1).ToString() + " de " + questoes.ToString() + " perguntas.";

    }

    public void respostas(string alternativa)
    {

        if (alternativa == "A")
        {
            audio.PlayOneShot(click);
            somaA += 1;

            proxima.interactable = true;
            anim1.gameObject.SetActive(false);
            anjoUm.gameObject.SetActive(false);
            anjoDois.gameObject.SetActive(true);
            sabe.gameObject.SetActive(true);
            if (idPergunta == 0)
            {
                conhecer++;

                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[0];
                }
                else
                {
                    sabermais.text = IngleSaberM[0];

                }
            }
            if (idPergunta == 1)
            {
                vcAma++;

                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[1];
                }
                else
                {

                    sabermais.text = IngleSaberM[1];
                }
            }
            if (idPergunta == 2)
            {
                vcAma++;

                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[2];
                }
                else
                {

                    sabermais.text = IngleSaberM[2];
                }
            }
            if (idPergunta == 3)
            {
                conhecer++;

                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[3];
                }
                else
                {

                    sabermais.text = IngleSaberM[3];
                }
            }
            if (idPergunta == 4)
            {
                amor++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[4];
                }
                else
                {

                    sabermais.text = IngleSaberM[4];
                }

            }
            if (idPergunta == 5)
            {

                amor++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[5];
                }
                else
                {

                    sabermais.text = IngleSaberM[5];
                }
            }
            if (idPergunta == 6)
            {

                amor++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[6];
                }
                else
                {

                    sabermais.text = IngleSaberM[6];
                }
            }
            if (idPergunta == 7)
            {

                amor++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[7];
                }
                else
                {

                    sabermais.text = IngleSaberM[7];
                }
            }
            if (idPergunta == 8)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[8];
                }
                else
                {

                    sabermais.text = IngleSaberM[8];
                }
                amor++;
            }
            if (idPergunta == 9)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[9];
                }
                else
                {

                    sabermais.text = IngleSaberM[9];
                }
                amor++;
            }
            if (idPergunta == 10)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[10];
                }
                else
                {

                    sabermais.text = IngleSaberM[10];
                }
                paixao++;
            }
            if (idPergunta == 11)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[11];
                }
                else
                {

                    sabermais.text = IngleSaberM[11];
                }
                amor++;
            }
            if (idPergunta == 12)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[12];
                }
                else
                {

                    sabermais.text = IngleSaberM[12];
                }
                amor++;
            }
            if (idPergunta == 13)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[13];
                }
                else
                {

                    sabermais.text = IngleSaberM[13];
                }
                amor++;
            }
            if (idPergunta == 14)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[14];
                }
                else
                {

                    sabermais.text = IngleSaberM[14];
                }
                amor++;
            }
            if (idPergunta == 15)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[15];
                }
                else
                {

                    sabermais.text = IngleSaberM[15];
                }
                personalidadeDele = 1;
            }
            if (idPergunta == 16)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[16];
                }
                else
                {

                    sabermais.text = IngleSaberM[16];
                }
                personalidadeDela = 1;
                if (personalidadeDela == 1 && personalidadeDele == 1 || personalidadeDela == 1 && personalidadeDele == 2 || personalidadeDela == 2 && personalidadeDele == 1)
                {
                    personalidade = true;
                    compativel = 1;
                    if (Application.systemLanguage == SystemLanguage.Portuguese)
                    {
                        sabermais.text = saberM[16] + " Resultado =  Suas personalidades são compatíveis !";
                    }
                    else
                    {

                        sabermais.text = IngleSaberM[16] + " Result = Your personalities are compatible!";
                    }

                }
            }

            btnRespostaA.interactable = false;
            btnRespostaB.interactable = false;
            btnRespostaC.interactable = false;
            btnRespostaD.interactable = false;
            btnRespostaE.interactable = false;


        }
        else if (alternativa == "B")
        {
            audio.PlayOneShot(click);
            somaB += 1;
            anim1.gameObject.SetActive(false);
            anjoUm.gameObject.SetActive(false);
            anjoDois.gameObject.SetActive(true);
            proxima.interactable = true;
            sabe.gameObject.SetActive(true);

            if (idPergunta == 0)
            {
                cuidado++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[0];
                }
                else
                {

                    sabermais.text = IngleSaberM[0];
                }
            }
            if (idPergunta == 1)
            {
                cuidado++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[1];
                }
                else
                {

                    sabermais.text = IngleSaberM[1];
                }
            }
            if (idPergunta == 2)
            {
                cuidado++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[2];
                }
                else
                {

                    sabermais.text = IngleSaberM[2];
                }
            }
            if (idPergunta == 3)
            {
                cuidado++;
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[3];
                }
                else
                {

                    sabermais.text = IngleSaberM[3];
                }
            }

            if (idPergunta == 4)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[4];
                }
                else
                {

                    sabermais.text = IngleSaberM[4];
                }
                indeciso++;
            }
            if (idPergunta == 5)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[5];
                }
                else
                {

                    sabermais.text = IngleSaberM[5];
                }
                naoGosta++;
            }
            if (idPergunta == 6)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[6];
                }
                else
                {

                    sabermais.text = IngleSaberM[6];
                }
                naoGosta++;
            }
            if (idPergunta == 7)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[7];
                }
                else
                {

                    sabermais.text = IngleSaberM[7];
                }
                naoGosta++;
            }
            if (idPergunta == 8)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[8];
                }
                else
                {

                    sabermais.text = IngleSaberM[8];
                }
                naoGosta++;
            }
            if (idPergunta == 9)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[9];
                }
                else
                {

                    sabermais.text = IngleSaberM[9];
                }
                naoGosta++;
            }
            if (idPergunta == 10)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[10];
                }
                else
                {

                    sabermais.text = IngleSaberM[10];
                }
                naoGosta++;
            }
            if (idPergunta == 12)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[12];
                }
                else
                {

                    sabermais.text = IngleSaberM[12];
                }
                naoGosta++;
            }
            if (idPergunta == 13)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[13];
                }
                else
                {

                    sabermais.text = IngleSaberM[13];
                }
                naoGosta++;
            }
            if (idPergunta == 14)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[14];
                }
                else
                {

                    sabermais.text = IngleSaberM[14];
                }
                indeciso++;
            }
            if (idPergunta == 15)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[15];
                }
                else
                {

                    sabermais.text = IngleSaberM[15];
                }
                personalidadeDele = 2;
            }
            if (idPergunta == 16)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[16];
                }
                else
                {

                    sabermais.text = IngleSaberM[16];
                }
                personalidadeDela = 2;
                if (personalidadeDela == 1 && personalidadeDele == 1 || personalidadeDela == 1 && personalidadeDele == 2 || personalidadeDela == 2 && personalidadeDele == 1)
                {
                    personalidade = true;
                    compativel = 1;
                    if (Application.systemLanguage == SystemLanguage.Portuguese)
                    {
                        sabermais.text = saberM[16] + " Suas personalidades são compatíveis !";
                    }
                    else
                    {

                        sabermais.text = IngleSaberM[16] + " Result = Your personalities are compatible!";
                    }

                }
            }

            btnRespostaA.interactable = false;
            btnRespostaB.interactable = false;
            btnRespostaC.interactable = false;
            btnRespostaD.interactable = false;
            btnRespostaE.interactable = false;


        }
        else if (alternativa == "C")
        {
            audio.PlayOneShot(click);
            somaC += 1;
            anim1.gameObject.SetActive(false);
            anjoUm.gameObject.SetActive(false);
            anjoDois.gameObject.SetActive(true);
            proxima.interactable = true;
            sabe.gameObject.SetActive(true);
            if (idPergunta == 0)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[0];
                }
                else
                {

                    sabermais.text = IngleSaberM[0];
                }
                cuidado++;
            }
            if (idPergunta == 1)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[1];
                }
                else
                {

                    sabermais.text = IngleSaberM[1];
                }
                paixao++;
            }
            if (idPergunta == 2)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[2];
                }
                else
                {

                    sabermais.text = IngleSaberM[2];
                }
                paixao++;
            }
            if (idPergunta == 3)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[3];
                }
                else
                {

                    sabermais.text = IngleSaberM[3];
                }
                conhecer++;
            }
            if (idPergunta == 4)
            {

                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[4];
                }
                else
                {

                    sabermais.text = IngleSaberM[4];
                }

                indeciso++;
            }
            if (idPergunta == 5)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[5];
                }
                else
                {

                    sabermais.text = IngleSaberM[5];
                }
                naoGosta++;
            }
            if (idPergunta == 6)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[6];
                }
                else
                {

                    sabermais.text = IngleSaberM[6];
                }
                naoGosta++;
            }
            if (idPergunta == 7)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[7];
                }
                else
                {

                    sabermais.text = IngleSaberM[7];
                }
                naoGosta++;
            }
            if (idPergunta == 8)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[8];
                }
                else
                {

                    sabermais.text = IngleSaberM[8];
                }
                indeciso++;
            }
            if (idPergunta == 9)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[9];
                }
                else
                {

                    sabermais.text = IngleSaberM[9];
                }
                amizade++;
            }
            if (idPergunta == 10)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[10];
                }
                else
                {

                    sabermais.text = IngleSaberM[10];
                }
                amizade++;
            }
            if (idPergunta == 11)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[11];
                }
                else
                {

                    sabermais.text = IngleSaberM[11];
                }
                paixao++;
            }
            if (idPergunta == 12)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[12];
                }
                else
                {

                    sabermais.text = IngleSaberM[12];
                }
                indeciso++;
            }
            if (idPergunta == 13)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[13];
                }
                else
                {

                    sabermais.text = IngleSaberM[13];
                }
                amizade++;
            }
            if (idPergunta == 14)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[14];
                }
                else
                {

                    sabermais.text = IngleSaberM[14];
                }
                naoGosta++;
            }
            if (idPergunta == 15)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[15];
                }
                else
                {

                    sabermais.text = IngleSaberM[15];
                }
                personalidadeDele = 3;
            }
            if (idPergunta == 16)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[16];
                }
                else
                {

                    sabermais.text = IngleSaberM[16];
                }
                personalidadeDela = 3;
                if (personalidadeDela == 3 && personalidadeDele == 3)
                {
                    personalidade = false;
                    compativel = 0;
                    if (Application.systemLanguage == SystemLanguage.Portuguese)
                    {
                        sabermais.text = saberM[16] + " Resultado = As personalidades não são compatíveis !";
                    }
                    else
                    {

                        sabermais.text = IngleSaberM[16] + " Result = Personalities are not compatible!";
                    }

                    cuidado++;
                }
            }
            btnRespostaA.interactable = false;
            btnRespostaB.interactable = false;
            btnRespostaC.interactable = false;
            btnRespostaD.interactable = false;
            btnRespostaE.interactable = false;

        }
        else if (alternativa == "D")
        {
            audio.PlayOneShot(click);
            somaD += 1;
            anim1.gameObject.SetActive(false);
            anjoUm.gameObject.SetActive(false);
            anjoDois.gameObject.SetActive(true);
            proxima.interactable = true;
            sabe.gameObject.SetActive(true);

            if (idPergunta == 0)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[0];
                }
                else
                {

                    sabermais.text = IngleSaberM[0];
                }
                cuidado++;
            }
            if (idPergunta == 1)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[1];
                }
                else
                {

                    sabermais.text = IngleSaberM[1];
                }
                cuidado++;
            }
            if (idPergunta == 2)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[2];
                }
                else
                {

                    sabermais.text = IngleSaberM[2];
                }
                cuidado++;
                if (idPergunta == 3)
                {
                    if (Application.systemLanguage == SystemLanguage.Portuguese)
                    {
                        sabermais.text = saberM[3];
                    }
                    else
                    {

                        sabermais.text = IngleSaberM[3];
                    }
                    conhecer++;
                }
            }
            if (idPergunta == 4)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[4];
                }
                else
                {

                    sabermais.text = IngleSaberM[4];
                }

                naoGosta++;
            }
            if (idPergunta == 5)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[5];
                }
                else
                {

                    sabermais.text = IngleSaberM[5];
                }
                naoGosta++;
            }
            if (idPergunta == 6)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[6];
                }
                else
                {

                    sabermais.text = IngleSaberM[6];
                }
                indeciso++;
            }
            if (idPergunta == 7)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[7];
                }
                else
                {

                    sabermais.text = IngleSaberM[7];
                }
                indeciso++;
            }
            if (idPergunta == 8)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[8];
                }
                else
                {

                    sabermais.text = IngleSaberM[8];
                }
                amizade++;
            }
            if (idPergunta == 9)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[9];
                }
                else
                {

                    sabermais.text = IngleSaberM[9];
                }
                naoGosta++;
            }
            if (idPergunta == 10)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[10];
                }
                else
                {

                    sabermais.text = IngleSaberM[10];
                }
                naoGosta++;
            }
            if (idPergunta == 11)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[11];
                }
                else
                {

                    sabermais.text = IngleSaberM[11];
                }
                indeciso++;
            }
            if (idPergunta == 12)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[12];
                }
                else
                {

                    sabermais.text = IngleSaberM[12];
                }
                indeciso++;
            }
            if (idPergunta == 13)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[13];
                }
                else
                {

                    sabermais.text = IngleSaberM[13];
                }
                amizade++;
            }
            if (idPergunta == 14)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[14];
                }
                else
                {

                    sabermais.text = IngleSaberM[14];
                }
                amizade++;
            }
            if (idPergunta == 15)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[15];
                }
                else
                {

                    sabermais.text = IngleSaberM[15];
                }
                personalidadeDele = 4;
            }
            if (idPergunta == 16)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    sabermais.text = saberM[16];
                }
                else
                {

                    sabermais.text = IngleSaberM[16];
                }
                personalidadeDela = 4;
                if (personalidadeDela == 4 && personalidadeDele == 4)
                {
                    personalidade = false;
                    compativel = 0;
                    if (Application.systemLanguage == SystemLanguage.Portuguese)
                    {
                        sabermais.text = saberM[16] + " Resultado = As personalidades não são compatíveis !";
                    }
                    else
                    {

                        sabermais.text = IngleSaberM[16] + "Result = Personalities are not compatible!";
                    }

                    cuidado++;
                }
            }
            btnRespostaA.interactable = false;
            btnRespostaB.interactable = false;
            btnRespostaC.interactable = false;
            btnRespostaD.interactable = false;
            btnRespostaE.interactable = false;

        }

        if (alternativa == "OK")
        {

            proximaPergunta();

        }


    }
    void proximaPergunta()
    {

        idPergunta += 1;


        if (idPergunta <= (questoes - 1))
        {

            proxima.interactable = false;
            Detalhes.interactable = false;
            Detalhes1.interactable = false;
            Detalhes2.interactable = false;
            Detalhes3.interactable = false;

            btnRespostaA.interactable = true;
            btnRespostaB.interactable = true;
            btnRespostaC.interactable = true;
            btnRespostaD.interactable = true;

            sabe.gameObject.SetActive(false);
            anim1.gameObject.SetActive(true);
            anjoUm.gameObject.SetActive(true);
            anjoDois.gameObject.SetActive(false);



            respostaCerta.text = "";

            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];
            sabermais.text = saberM[idPergunta];



        }
        else
        {


            PlayerPrefs.SetInt("idTema", idTela);

            PlayerPrefs.SetInt("Amor", amor);
            PlayerPrefs.SetInt("Amizade", amizade);
            PlayerPrefs.SetInt("Paixao", paixao);
            PlayerPrefs.SetInt("Indeciso", indeciso);
            PlayerPrefs.SetInt("naoGosta", naoGosta);
            PlayerPrefs.SetInt("VcAma", vcAma);
            PlayerPrefs.SetInt("Cuidado", cuidado);
            PlayerPrefs.SetInt("Conhecer", conhecer);
            PlayerPrefs.SetInt("Compativel", compativel);


            Application.LoadLevel("resultado");
        }

    }

    void Update()
    {
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];
    }

}