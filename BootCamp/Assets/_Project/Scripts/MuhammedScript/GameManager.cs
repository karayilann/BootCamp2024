using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        
        public TextMeshProUGUI gameText;
        public Button option1Button;
        public Button option2Button;
        public Image backgroundImage;

        public Sprite acilisVeHapsiBoyladin;
        public Sprite yaraliKadin;
        public Sprite yakalamaAni;
        public Sprite sorguOdasi;
        public Sprite cmkAvukat;
        public Sprite unluAvukat;
        public Sprite gordukleriniAnlatKatilResmi;

        
        
        private GameState currentState;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<GameManager>();
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        void Start()
        {
            ChangeState("start");
        }

        void ChangeState(string newStateId)
        {
            if (GameData.States.TryGetValue(newStateId, out currentState))
            {
                UpdateUI();
            }
            else
            {
                Debug.LogError("State not found: " + newStateId);
            }
        }

        void UpdateUI()
        {
            gameText.text = currentState.StateText;

            if (currentState.BackgroundImage != null)
            {
                backgroundImage.sprite = currentState.BackgroundImage;  // Update the background image
            }

            if (currentState.Options.Length > 0)
            {
                option1Button.gameObject.SetActive(true);
                option1Button.GetComponentInChildren<TextMeshProUGUI>().text = currentState.Options[0].OptionText;
                option1Button.onClick.RemoveAllListeners();
                option1Button.onClick.AddListener(() => ChangeState(currentState.Options[0].NextState));

                if (currentState.Options.Length > 1)
                {
                    option2Button.gameObject.SetActive(true);
                    option2Button.GetComponentInChildren<TextMeshProUGUI>().text = currentState.Options[1].OptionText;
                    option2Button.onClick.RemoveAllListeners();
                    option2Button.onClick.AddListener(() => ChangeState(currentState.Options[1].NextState));
                }
                else
                {
                    option2Button.gameObject.SetActive(false);
                }
            }
            else
            {
                option1Button.gameObject.SetActive(false);
                option2Button.gameObject.SetActive(false);
            }
        }
    }
}