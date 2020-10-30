using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy [] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }
    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies) 
        {
            if (enemy!= null)
                    return;
        }

            Debug.Log("You killed all Enemies");

            _nextLevelIndex++;
            string nextlevelName = "Level1" + _nextLevelIndex;
            SceneManager.LoadScene(nextlevelName);
        
    }
}
