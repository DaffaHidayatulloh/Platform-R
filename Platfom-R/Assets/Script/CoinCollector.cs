using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text coinText; // Untuk ambil refrensi text
    private int coinCount = 0; // Variabel untuk menyimpan jumlah koin

    void OnTriggerEnter2D(Collider2D other)
    {
        // Mengecek apakah objek yang disentuh adalah koin
        if (other.gameObject.tag == "Coin")
        {
            coinCount++; // Tambahkan jumlah koin
            coinText.text = "Coins: " + coinCount; // Perbarui teks di layar
            Destroy(other.gameObject); // Hapus koin dari game
        }
    }
}
