using System;
using UnityEngine;
using UnityEngine.EventSystems;
 
public class ButtonRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private GameObject player;
    private Rigidbody2D playerRg;
    private bool buttonPressedRight;
    private float jumpForce;
    private float xForce;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRg = player.GetComponent<Rigidbody2D>();
        jumpForce = 0f;
        xForce = 0f;
    }

    private void Update()
    {
        if (buttonPressedRight && player != null)
        {
            player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            jumpForce += (Time.deltaTime * 15f);
            xForce += (Time.deltaTime * 10f);
        }
        else if (!buttonPressedRight && player != null)
        {
            playerRg.AddForce(new Vector2(xForce, jumpForce), ForceMode2D.Impulse);
            jumpForce = 0.01f;
            xForce = 0.01f;
        }
    }
    
    public void OnPointerDown(PointerEventData eventData){
        buttonPressedRight = true;
    }
 
    public void OnPointerUp(PointerEventData eventData){
        buttonPressedRight = false;
    }
}