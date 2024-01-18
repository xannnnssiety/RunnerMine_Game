using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Скорость перемещения персонажа

    public bool isGrounded;
    private Rigidbody rb;

    public static int coins;
    public Text coinsText;

    public GameObject GameOver;


    public AudioSource coinClip;
    



    void Start()
    {
        
        coins = PlayerPrefs.GetInt("coins");
        /*coinsText.text = coins.ToString();*/

        
        Score.scoreMultiplier = 2;

        GameOver.SetActive(false);
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
        
    }

    void Update()
    {
        // Получаем входные данные от клавиатуры
        float horizontalInput = Input.GetAxis("Horizontal");

        // Вычисляем новую позицию персонажа
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime;

        // Применяем новую позицию
        transform.position = newPosition;

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0, 300, 0));
        }

        if (Input.GetKeyDown(KeyCode.S)) // Если нажата клавиша S
        {
            // Резкое падение вниз (можно изменить значение вектора на ваше усмотрение)
            rb.velocity = new Vector3(rb.velocity.x, -10f, rb.velocity.z);
        }

        coinsText.text = coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins++;
            coinClip.Play();
            PlayerPrefs.SetInt("coins", coins);
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "BonusStar")
        {
            coinClip.Play();
            StartCoroutine(StarBonus());
            Destroy(other.gameObject);
        }


    }

    private IEnumerator StarBonus()
    {
        Score.scoreMultiplier = Score.Bonus;
        

        yield return new WaitForSeconds(15);

        if (PlayerPrefs.HasKey("scMulti"))
        {
            Score.scoreMultiplier = PlayerPrefs.GetInt("scMulti");
        }
        else
        {
            Score.scoreMultiplier = 1;
        }


    }





}
