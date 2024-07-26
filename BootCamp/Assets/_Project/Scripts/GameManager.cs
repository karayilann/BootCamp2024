using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI gameText;
        public Button option1Button;
        public Button option2Button;

        private GameState currentState;

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