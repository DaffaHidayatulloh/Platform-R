using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Kecepatan gerak karakter.
    public float jumpForce = 10f; // Kekuatan lompatan karakter.
    private Rigidbody2D rb; // Komponen fisik untuk karakter.
    private bool isGrounded; // Mengecek apakah karakter berada di tanah.
                             // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Menghubungkan kode dengan komponen Rigidbody2D di karakter.
    }

    void Update()
    {
        // Gerakan horizontal (kanan dan kiri).
        float move = Input.GetAxis("Horizontal"); // Menerima input dari tombol panah atau A/D.
        rb.velocity = new Vector2(move * speed, rb.velocity.y); // Mengatur kecepatan berdasarkan input.

        // Lompatan.
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Jika tombol spasi ditekan dan karakter berada di tanah.
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Memberikan dorongan ke atas.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") // Mengecek apakah karakter menyentuh tanah.
        {
            isGrounded = true; // Tandai bahwa karakter berada di tanah.
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") // Mengecek apakah karakter tidak lagi menyentuh tanah.
        {
            isGrounded = false; // Tandai bahwa karakter tidak berada di tanah.
        }
    }
}
