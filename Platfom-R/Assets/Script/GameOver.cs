using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel; //Untuk mengambil refrensi ke panel game over

    void OnTriggerEnter2D(Collider2D other)
    {
        // Mengecek apakah pemain menyentuh objek dengan tag "Finish"
        if (other.gameObject.tag == "Player")
        {
            GameOverPanel.SetActive(true); // Menampilkan panel
            Time.timeScale = 0f; // Menghentikan permainan
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Muat ulang scene
    }
}
