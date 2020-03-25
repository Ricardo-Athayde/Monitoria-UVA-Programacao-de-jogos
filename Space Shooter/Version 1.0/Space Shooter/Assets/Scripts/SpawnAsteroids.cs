using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    [SerializeField] GameObject[] asteroidPrefabs = default; //Prefab dos asteroides
    [SerializeField] float spawnSize = default; //Qual largura em X que os asteroides podem aparecer
    [SerializeField] float spawnDelay = default; //Quanto tempo demora para criar um novo asteroide
    [SerializeField] float delayDecrease = default; //Velocidade com que o spawnDelay diminui
    [SerializeField] float minDelay = default; //Menor valor que o spawnDelay pode receber
    [SerializeField] Vector2 randomSize = default; //Minimo e maximo do tamanho do asteroide
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn()); //Inicia a criacao dos asteroides
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay -= delayDecrease * Time.deltaTime; //Diminui a demora para criacao de um asteroide
        if(spawnDelay < minDelay) //Caso spawnDelay seja menor que o minimo
        {
            spawnDelay = minDelay; //Colocamos a demora como a minima possivel
        }
    }

    IEnumerator Spawn() //Cria os asteroides
    {
        //Cria um novo asteroide e guarda uma referencia para ele
        GameObject newAsteroid = Instantiate(asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)], //Escolhe um prefab de asteroid aleatorio
                                            new Vector3(Random.Range(-spawnSize, spawnSize), transform.position.y, transform.position.z), //Escolhe uma posiçao x aleatoria
                                            Quaternion.Euler(0, 0, Random.Range(0f, 360f))); //Escolhe uma rotaçao aleatoria

        float size = Random.Range(randomSize.x, randomSize.y); //Guarda um tamanho aleatorio
        newAsteroid.transform.localScale = new Vector3(size, size, size); //Aplica o tamanho aleatorio no novo asteroide    
        yield return new WaitForSeconds(spawnDelay); //Espera um tempo até criar um novo asteroide
        StartCoroutine(Spawn()); //Inicia novamente a criacao de um asteroide
    }
}
