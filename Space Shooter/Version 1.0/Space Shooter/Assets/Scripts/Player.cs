using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0,20)] //Faz com que o inspector da unity seja um slider que vai de 0 a 20
    [SerializeField] float velocity = default; //Velocidade de movimentacao do player
    [SerializeField] Vector2 screenSize = default; //Distancia que o player pode se movimeentar ante de ser impedido por uma parede invisivel
    [SerializeField] float invulnerableTime = default ; //tempo que fica invulneravel depois de ser atingido
    public int life; //Vida atual
    bool invulnerable; //Se esta invulneravel
    
    // Update is called once per frame
    void Update()
    {
        Movement(); //Cuida das movimentacoes e inputs do player
    }

    private void OnTriggerEnter2D(Collider2D collision) //Chamado sempre que a engine detecta que o objeto com esse script colidiu com outro objeto. Existem algumas restricoes para que ele considere uma colisao
    {
        if(collision.tag == "Asteroid" && !invulnerable) //Verifica se o objeto que eu colidi tem a tag de Asteroide
        {
            StartCoroutine(TookDmg()); //Chama a corotina de tomar dano
        }
    }

    IEnumerator TookDmg()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>(); //Pega o stript sprite renderer nesse objeto
        life--; //diminui a vida
        invulnerable = true; //torna invulneravel
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0.2f);  //Coloca a cor do sprite renderer para ter 20% de opacidade
        yield return new WaitForSeconds(invulnerableTime);
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1f); //Coloca a opacidade em 100%
        invulnerable = false; //Deixa de ser invulneravel
    }
    
    void Movement()
    {
        if (Input.GetKey(KeyCode.W)) //Caso o player tenha apertado a tecla W
        {
            transform.Translate(new Vector3(0, velocity * Time.deltaTime, 0)); //Movimentamos o player no eixo Y
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -velocity * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocity * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-velocity * Time.deltaTime, 0, 0));
        }


        if (transform.position.x > screenSize.x) //Caso o player tenha saido da area de jogo, retornamos ele para dentro dela
        {
            transform.position = new Vector3(screenSize.x, transform.position.y, transform.position.y);
        }
        if (transform.position.x < -screenSize.x)
        {
            transform.position = new Vector3(-screenSize.x, transform.position.y, transform.position.y);
        }
        if (transform.position.y > screenSize.y)
        {
            transform.position = new Vector3(transform.position.x, screenSize.y, transform.position.y);
        }
        if (transform.position.y < -screenSize.y)
        {
            transform.position = new Vector3(transform.position.x, -screenSize.y, transform.position.y);
        }
    }
}
