using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameOver : MonoBehaviour
{ 
[SerializeField] private bool invertV;
[SerializeField] private int pontos;
private bool estaVivo;
    private bool rb;
    private float moveH;
    private float moveV;

[Header("Sons da Bolinha")]
[SerializeField] private AudioClip pulo;
[SerializeField] private AudioClip pegaCubo;
private AudioSource audioPlayer;
private TextMeshProUGUI textoPontos;
private TextMeshProUGUI textoTotal;

[Header("HUD")]
[SerializeField] private List<Sprite> emojis = new List<Sprite>();
[SerializeField] private GameObject telaGameOver;

    // Start is called before the first frame update
    void Start()
    {
        estaVivo = true;
        rb = GetComponent<Rigidbody>();
        audioPlayer = GetComponent<AudioSource>();
        textoPontos = GameObject.FindGameObjectWithTag("Pontos").GetComponent<TextMeshProUGUI>();
        textoTotal = GameObject.Find("TotalCubos").GetComponent<TextMeshProUGUI>();
        textoTotal.text = GameObject.FindGameObjectsWithTag("CuboBrilhante").Length.ToString();
        telaGameOver = GameObject.Find("GameOver");
        telaGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (estaVivo)
        {
            // movimento
            moveH = Input.GetAxis("Horizontal");
            moveV = Input.GetAxis("Vertical");

            transform.position += new Vector3();

            // pulo
            if (Input.GetKeyDown(KeyCode.Escape))
                VerificaObjetos();

        }
        else
        {
            telaGameOver.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other);


    private void OnCollisionEnter(Collision collision);


 
}
