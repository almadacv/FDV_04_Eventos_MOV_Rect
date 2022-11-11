using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerMov : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public int PlayerHealth = 100;
    public int Score = 0;
    
    void Update()
    {

        // move player
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        
        if(PlayerHealth==0||PlayerHealth<0)
        {
            Destroy(gameObject);
        }

    }

    public void SetSpeedMov()
    {
        //Debug.Log(speed);
        speed = speed == 10.0f ? 100.0f : 10.0f;
    }
    public void AddScore()
    {
        Score++;
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = $"Score : {Score}";
    }
    public void HealthUpdate()
    {
        PlayerHealth--;
        GameObject.Find("Saude").GetComponent<TextMeshProUGUI>().text = $"Health : {PlayerHealth}%";
    }

   /*  public void Teleport()
    {
        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }
 */



}
