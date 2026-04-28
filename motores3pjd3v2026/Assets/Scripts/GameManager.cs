using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState CurrentState;

    [Header("Player Input")]
    public PlayerInput playerInput;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetState(GameState.Iniciando);
    }

    public void SetState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado atual: " + CurrentState);
    }

    // Controle de cenas (somente o GameManager usa SceneManager)
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Métodos específicos
    public void GoToMenu()
    {
        SetState(GameState.MenuPrincipal);
        LoadScene("MenuPrincipal");
    }

    public void StartGame()
    {
        SetState(GameState.Gameplay);
        LoadScene("GetStarted_Scene");
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

    // Alocação de input (simples)
    public void AssignInput(PlayerInput input)
    {
        playerInput = input;
        Debug.Log("Input atribuído ao jogador");
    }
}