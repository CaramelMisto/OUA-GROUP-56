using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace GameManager{
    public class Player : MonoBehaviour
    {
        private Rigidbody _rb;

        private Joystick joystick;

        [SerializeField] private Transform astranoutTransform;

        [SerializeField] private float leftRightSpeed;
        private TextMeshProUGUI coinsTxt;

        [SerializeField] private Vector2 MinMaxX;

        private void Awake()
        {
            joystick = GameObject.Find("Floating Joystick").GetComponent<Joystick>();
            
            Debug.Log(joystick == null);
            coinsTxt = GameObject.Find("coinsTxt").GetComponent<TextMeshProUGUI>();
            _rb = GetComponent<Rigidbody>();
            coinsTxt.text = Savings.savedObject.coins.ToString();
        }

        private void Update()
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinMaxX.x, MinMaxX.y), transform.position.y, transform.position.z);
            _rb.velocity = new Vector3(joystick.Horizontal * leftRightSpeed * Time.deltaTime /Time.timeScale, _rb.velocity.y, 0);

            astranoutTransform.rotation = Quaternion.Euler(0, joystick.Horizontal * 45, 0);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                Destroy(other.transform.root.gameObject);
                coinsTxt.text = (++Savings.savedObject.coins).ToString();
            }
        }
    }
}