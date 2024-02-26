using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;

    Vector2 m_startPos, m_playerPos;

    [SerializeField]
    short m_speed = 20;

    public void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        moving();
        rb.position = m_playerPos;
    }

    void moving() {
        if (!GameManager.instance.compareGameState(GameStates.Playing)) {
            return;
        }

        for (short i = 0; i < Input.touchCount; i++) {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(rb.position, touchPosition, Color.yellow);
            print(touchPosition);

            if (Input.GetTouch(0).phase == TouchPhase.Began) {

                rb.AddForce(new Vector2(touchPosition.x * (m_speed * 20f) * Time.deltaTime, touchPosition.y * (m_speed * 20f) * Time.deltaTime));
            } else {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
