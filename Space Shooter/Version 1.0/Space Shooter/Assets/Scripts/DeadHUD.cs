using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Necessario para utilizar o sistema de troca de cenas
using UnityEngine.UI; //Necessario para usar scripts relacionados a UI como a variavel Image e Text

public class DeadHUD : MonoBehaviour
{
    [SerializeField] Text score; //Caixa de texto que mostra o score
    [SerializeField] GameManager gameManager; //referencia para o Game Manager

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + gameManager.score; //Atualiza a caixa de texto com o score atual
    }

    public void TryAgainButton(string sceneName) //Chamado pelo botao de "Tentar Denovo"
    {
        SceneManager.LoadScene(sceneName); //Carrega a cena sceneName e descarrega a cena atual
    }
}
