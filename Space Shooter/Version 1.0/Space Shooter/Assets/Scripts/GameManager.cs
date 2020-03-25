using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player player = default; //Referencia para o player
    [SerializeField] GameObject hud = default; //O canvas que contem o HUD do jogo
    [SerializeField] GameObject deadScreen = default; //O canvas que contem a tela de morte
    [SerializeField] GameObject asteroidSpawner = default; //O objeto criador de asteroides

    public int score; //Score atual
    float realScore; //Score completo, usado para que possamos ter mais controle sobre o real score. Serve também para impedir que pessoas possam manipular facilmente o score usando ferramentas como Cheat Engine
    bool dead; //Controla se o player morreu


    // Update is called once per frame
    void Update()
    {
        if(player.life <= 0) //Caso o player tenha morrido
        {
            dead = true; 
            deadScreen.SetActive(true); //Ativa a tela de morte
            hud.SetActive(false); //Remove o HUD
            player.gameObject.SetActive(false); //Remove o Player da tela
            asteroidSpawner.SetActive(false); //Para o criador de asteroides
        }
        else //Caso nçao esteja morto
        {
            realScore += Time.deltaTime * player.life; //Atualiza o score atual
            score = Mathf.RoundToInt(realScore); //Atualiza o score que o player ve
        }
    }
}
