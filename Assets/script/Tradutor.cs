using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Linq;


public class Tradutor : MonoBehaviour {
    //tela inicial
    public int cena;
    public Text tituloTelaInicial;
    public Button botaoIniciar;
    //tela 3
    public Text informacoesTitulo;
    public Button botaoContinuar;
    public Text textoInformacoes;
    //tela 4 quem
    public Text perguntaTextoQuem;
    public Text botaoUmTextoQuem;
    public Text botaoDoisTextoQuem;
    public Button botaoMenuTextoQuem;
    public Button botaoContinuarTextoQuem;
    public int idQuem;
    // quero saber
    public Button saberUM;
    public Button saberDois;
    public Button continuarSaber;
    public Text tituloQueroSaber;
    public Text tituloresultados;
    //t1
    public Text textoTituloTela;

    // Use this for initialization
    void Start() {
    }
   // Parabéns! Você chegou ao final do jogo! Espero que você tenha aprendido um pouco de matemática comigo.
    // Update is called once per frame
    void Update () {
            if (cena == 0)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    botaoIniciar.GetComponentInChildren<Text>().text = "Iniciar teste";


                }
                else
                {
                    botaoIniciar.GetComponentInChildren<Text>().text = "Start Test";


                }
            }
            if (cena == 12)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {

                }
                else
                {


                }
            }
            if (cena == 1)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {

                textoTituloTela.text = "Responda";

                }
                else
                {



                }
            }
            if (cena == 2)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                textoTituloTela.text = "Responda";


            }
                else
                {


                }
            }
            if (cena == 3)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    //tela inicial
                    informacoesTitulo.text = "Informações";
                    botaoContinuar.GetComponentInChildren<Text>().text = "Continuar";
                    textoInformacoes.text = "Olá como vai você? My love é um software que foi desenvolvido para ajudar as pessoas a escolher a combinação perfeita e descobrir os caminhos do coração.Esta aplicação é apenas um jogo de perguntas e respostas.não deve ser usado com tanta seriedade, pois apenas ajuda a encontrar a combinação perfeita.";
                }
                else
                {


                }
            }
            if (cena == 4)
            {
                if (Application.systemLanguage == SystemLanguage.Portuguese)
                {
                    //tela inicial


                    if (idQuem == 0)
                    {
                        perguntaTextoQuem.text = "Você é menino ou menina?";
                        botaoUmTextoQuem.text = "Menina";
                        botaoDoisTextoQuem.text = "Menino";
                    }
                    if (idQuem == 1)
                    {
                        perguntaTextoQuem.text = "Você é maior de 18 anos?";
                        botaoUmTextoQuem.text = "Sou maior de 18 anos";
                        botaoDoisTextoQuem.text = "Sou menor de 18 anos";

                    }
                    botaoContinuarTextoQuem.GetComponentInChildren<Text>().text = "Continuar";
                 
            }
                else
                {
                    if (idQuem == 0)
                    {
                        perguntaTextoQuem.text = "Are you a girl or boy?";
                        botaoUmTextoQuem.text = "Girl";
                        botaoDoisTextoQuem.text = "Boy";
                    }
                    if (idQuem == 1)
                    {
                        perguntaTextoQuem.text = "You are 18 years old?";
                        botaoUmTextoQuem.text = "I am over 18 years old";
                        botaoDoisTextoQuem.text = "I'm under 18";
                    }



                }
            }
        if (cena == 5)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
               
                saberUM.GetComponentInChildren<Text>().text = "Se ela me ama";
                saberDois.GetComponentInChildren<Text>().text = "Se ele me ama";
                continuarSaber.GetComponentInChildren<Text>().text = "Continuar";
                tituloQueroSaber.text = "Eu quero saber?";

            }
           
        }
        if (cena == 7)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {

               
                tituloresultados.text = "Resultado";

            }

        }

    }

}
