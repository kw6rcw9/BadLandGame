using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class Game
    {
        public bool InGame { get; set; }

        public Game()
        {
            InGame = false;
        }
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Lose()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
