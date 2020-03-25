using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] Vector2 moveVelocity = default; //Velocidade com que o background se move
    [SerializeField] Vector2 minMaxY = default; //Menor/Maior Y que o background pode ter
    [SerializeField] Vector2 minMaxX = default; //Menor/Maior X que o background pode ter

    [SerializeField] bool rotateOnReset = default; //Deve rotationar toda vez que for resetado

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveVelocity.x * Time.deltaTime, moveVelocity.y * Time.deltaTime), Space.World); //Move o background

        if(transform.position.y > minMaxY.y) //Caso tenha saido da area limite
        {
            transform.position = new Vector3(transform.position.x, minMaxY.x, transform.position.z); //Coloca novamente na area limite
            if(rotateOnReset)
            {
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360)); //Rotaciona aleatoriamente 
            }            
        }
        if (transform.position.y < minMaxY.x)
        {
            transform.position = new Vector3(transform.position.x, minMaxY.y, transform.position.z);
            if (rotateOnReset)
            {
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            }
        }

        if (transform.position.x > minMaxX.y)
        {
            transform.position = new Vector3(minMaxX.x, transform.position.y, transform.position.z);
            if (rotateOnReset)
            {
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            }
        }
        if (transform.position.x < minMaxX.x)
        {
            transform.position = new Vector3(minMaxX.y, transform.position.y, transform.position.z);
            if (rotateOnReset)
            {
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            }
        }

    }
}
