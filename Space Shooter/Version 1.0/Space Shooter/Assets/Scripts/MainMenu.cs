using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Necessario para utilizar o sistema de troca de cenas

public class MainMenu : MonoBehaviour
{
    public void StartButton(string sceneName) //Chamado pelo botao de Start
    {
        SceneManager.LoadScene(sceneName); //Carrega a cena sceneName e descarrega a cena atual
    }
}
