using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float speedY = default; //Velocidade que o asteroid vai cair
    [SerializeField] float minY = default; //Posicao Y minima para destruir o asteroide
    [SerializeField] float randomRotation = default; //Maximo de velocidade de rotação aleatoria
    float rotation; //a rotacao desse asteroid

    // Start is called before the first frame update
    void Start()
    {
        rotation = Random.Range(-randomRotation, randomRotation); //Assim que o asteroide e criado, calculamos a rotacao dele aleatoriamente
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speedY* Time.deltaTime, 0), Space.World); //Move o asteroide
        transform.Rotate(new Vector3(0, 0, rotation) * Time.deltaTime, Space.World); //Rotaciona o Asteroide
        if(transform.position.y < minY) //Caso a posicao Y do asteroide seja menor que o minimo
        {
            Destroy(gameObject); //Destruimos o asteroide
        }
    }
}
