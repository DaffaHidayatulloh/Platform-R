using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject finishPanel; // Untuk mengambil referensi ke panel UI
   

    void OnTriggerEnter2D(Collider2D other)
    {
        // Mengecek apakah pemain menyentuh objek dengan tag "Finish"
        if (other.gameObject.tag == "Player")
        {
            finishPanel.SetActive(true); // Menampilkan panel
            Time.timeScale = 0f; // Menghentikan permainan
        }
    }

    // Fungsi untuk restart game, dihubungkan ke tombol restart
    public void RestartGame()
    {
        Time.timeScale = 1f; // Lanjutkan game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Muat ulang scene
        finishPanel.SetActive(false);
    }
}