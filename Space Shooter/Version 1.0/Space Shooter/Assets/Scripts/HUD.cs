using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Necessario para usar scripts relacionados a UI como a variavel Image e Text

public class HUD : MonoBehaviour
{
    [SerializeField] Player player = default; //Referencia para o player
    [SerializeField] GameManager gameManager = default; //Referencia para o Game Manager
    [SerializeField] Image[] hearts = default; //Referencia para as imagens dos coracoes
    [SerializeField] Text score = default; //Referencia para Caixa de texto do score

    // Update is called once per frame
    void Update()
    {
        switch(player.life) //dependendo da vida do personagem, mudamos a cor dos coracoes
        {
            case 3:
                hearts[0].color = new Color(255, 255, 255, 1); //Cor Branca totalmente opaca
                hearts[1].color = new Color(255, 255, 255, 1);
                hearts[2].color = new Color(255, 255, 255, 1);
                break;
            case 2:
                hearts[0].color = new Color(255, 255, 255, 1);
                hearts[1].color = new Color(255, 255, 255, 1);
                hearts[2].color = new Color(255, 255, 255, 0.2f); //Cor Branca 20% opaca
                break;
            case 1:
                hearts[0].color = new Color(255, 255, 255, 1);
                hearts[1].color = new Color(255, 255, 255, 0.2f);
                hearts[2].color = new Color(255, 255, 255, 0.2f);
                break;
        }

        score.text = "Score: " + gameManager.score; //Atualiza a caixa de texto do score

    }    
}
