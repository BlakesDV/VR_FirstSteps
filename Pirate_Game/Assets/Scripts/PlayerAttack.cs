using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    [SerializeField] GameObject m_bulletPrefab;
    [SerializeField] ushort m_bulletSpeed, m_firerate = 1, m_numberOfProyectiles = 4, m_radius;
    Vector2 m_playerPos;

    private void Start() {
        m_radius = 5;
        m_bulletSpeed = 5;

    }
    private void Update() {
        m_playerPos = GetComponent<PlayerController>().rb.transform.position;
        StartCoroutine(Firing());
    }

    private IEnumerator Firing() {
        WaitForSeconds t_wait = new WaitForSeconds(m_firerate);
        while (true) {
            yield return t_wait;
            int t_angleStep = 360 / m_numberOfProyectiles;
            int t_angle = 0;
            for (ushort i = 0; i <= m_numberOfProyectiles - 1; i++) {
                float t_proyectileXPos = GetComponent<PlayerController>().rb.transform.position.x + Mathf.Sin((t_angle * Mathf.PI) / 180) * m_radius;
                float t_proyectileYPos = GetComponent<PlayerController>().rb.transform.position.y + Mathf.Cos((t_angle * Mathf.PI) / 180) * m_radius;

                Vector2 t_proyectileVector = new Vector2(t_proyectileXPos, t_proyectileYPos);
                Vector2 t_proyectileMoveDir = (t_proyectileVector - m_playerPos).normalized * m_bulletSpeed;

                var t_proj = Instantiate(m_bulletPrefab, m_playerPos, Quaternion.identity);
                t_proj.GetComponent<Rigidbody2D>().velocity = new Vector2(t_proyectileMoveDir.x, t_proyectileMoveDir.y);


                t_angle += t_angleStep;
            }
        }
    }
}
