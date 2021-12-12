using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	#region Variables to assign via the unity inspector [SerializeFields]
	
	public GameObject currentSelection = null;

	[SerializeField]
	private GameObject changeButtonSFX = null;

	[SerializeField]
	private float changeButtonSFXLength = 1.0f;

	[SerializeField]
	private GameObject chooseButtonSFX = null;

	[SerializeField]
	private float chooseButtonSFXLength = 1.0f;

	[SerializeField]
	private string ButtonTagName = "Button";

	[SerializeField]
	private bool bothPlayers = false;

	#endregion

	#region Variable Declarations
	private Vector2 movementInput;
	private bool changing = false;
	private float closest = 1000.0f;
	private GameObject closestObject;
	private PlayerMovement playerMovement;

	private bool firstSized = false;

	//Sfx variables.
	private bool changeButtonSFXPlayed = false;
	private bool chooseButtonSFXPlayed = false;
	#endregion

	#region Private Functions (Do not try to access from outside this class.)
	// Start is called before the first frame update
	void Start() 
	{
        if (!bothPlayers)
        {
			if (ButtonTagName == "Button")
            {
				playerMovement = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<PlayerMovement>();
            }
            else
            {
				playerMovement = GameObject.FindGameObjectWithTag("PlayerTwo").GetComponent<PlayerMovement>();
			}
		}
	}

	// Update is called once per frame
	void Update() {
        if (!bothPlayers)
        {
			movementInput = playerMovement.vMovement;
			if(playerMovement.rightTrigger > 0.7f)
            {
				OnRightTrigger(new InputAction.CallbackContext());
            }
        }
		if (!firstSized) {
			currentSelection.GetComponent<SpringDynamics>().SwitchSize();
			firstSized = true;
		}
		currentSelection.GetComponent<RectTransform>().anchoredPosition += movementInput;
		if (movementInput.magnitude > 0.6f && changing == false) {
			if (!changeButtonSFXPlayed)
			{
				changeButtonSFXPlayed = true;
				StartCoroutine("PlayChangeButtonSoundEffect");
			}
			List<GameObject> buttonArray = new List<GameObject>(GameObject.FindGameObjectsWithTag(ButtonTagName));
			buttonArray.Remove(currentSelection);
			buttonArray.ToArray();
			foreach (GameObject button in buttonArray) {
				if(Vector2.Dot(new Vector2(movementInput.x,movementInput.y),currentSelection.GetComponent<RectTransform>().position - button.GetComponent<RectTransform>().position) > 0.5f)
                {
					continue;
                }
				float distance = Vector2.Distance(button.GetComponent<RectTransform>().position, currentSelection.GetComponent<RectTransform>().position);// + new Vector2(movementInput.x * buttonDistanceCheck, movementInput.y * buttonDistanceCheck));
				if (distance < closest) {
					closest = distance;
					closestObject = button;
				}
			}
			if(closest != 1000.0f)
            {
				currentSelection.GetComponent<SpringDynamics>().SwitchSize();
				currentSelection = closestObject;
				currentSelection.GetComponent<SpringDynamics>().SwitchSize();
				closest = 1000.0f;
				changing = true;
				StartCoroutine(WaitSec(0.2f));
			}
		}
		
	}

	public void OnRightTrigger(InputAction.CallbackContext context) {
        if (!changing)
        {
			currentSelection.GetComponent<SpringDynamics>().React(0.7f);
			currentSelection.GetComponent<Button>().onClick.Invoke();
			if (!chooseButtonSFXPlayed)
			{
				chooseButtonSFXPlayed = true;
				StartCoroutine("PlayChooseButtonSoundEffect");
			}
			changing = true;
			StartCoroutine(WaitSec(0.2f));
		}
		
	}

	public void OnMovement(InputAction.CallbackContext value) {
		movementInput = value.ReadValue<Vector2>().normalized;
	}

	private IEnumerator WaitSec(float timeToWait) {
		yield return new WaitForSeconds(timeToWait);
		changing = false;
	}

	private IEnumerator PlayChangeButtonSoundEffect() {
		changeButtonSFX.SetActive(true);
		yield return new WaitForSeconds(changeButtonSFXLength);
		changeButtonSFX.SetActive(false);
		changeButtonSFXPlayed = false;
	}

	private IEnumerator PlayChooseButtonSoundEffect() {
		chooseButtonSFX.SetActive(true);
		yield return new WaitForSeconds(chooseButtonSFXLength);
		chooseButtonSFX.SetActive(false);
		chooseButtonSFXPlayed = false;
	}
	#endregion

	#region Public Functions
	public void ToggleChanging()
	{
		changing = !changing;
	}

	public void StartDuel()
    {
		SceneManager.LoadScene(1);
    }
	#endregion

}
