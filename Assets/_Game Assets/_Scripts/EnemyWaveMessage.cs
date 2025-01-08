using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWaveMessage : MonoBehaviour
{
    EnemySpawner enemySpawner;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    Text enemyWaveText;

    private IEnumerator WaveMessageCourutine()
    {
        enemyWaveText.gameObject.SetActive(true);
        for (int i = (int)enemySpawner.lastSpawnTime; i >= 0; i--)
        {
            enemyWaveText.text = "Enemy wave incoming in: " + i;
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(1);
        enemyWaveText.gameObject.SetActive(false);
    }

    void Awake()
    {
        enemySpawner = GetComponent<EnemySpawner>();
        enemyWaveText.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaveMessageCourutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
