using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private float speed;

    private float width = 1920;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBackground();
    }

    private void MoveBackground()
    {
        // Movimenta��o da imagem
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        
        // Se a imagem j� saiu da tela, troca de posi��o pro lado contr�rio
        if (transform.localPosition.x >= width)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - width * 2, 0, 0);
        }
        else if (transform.localPosition.x <= -width)
        {
            transform.localPosition = new Vector3(transform.localPosition.x + width * 2, 0, 0);
        }
        
    }
}
