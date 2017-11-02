using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainmenu : MonoBehaviour {

	public GameObject _SettingsMenuPrefab;
	public Transform _SettingsMenuTarget;
	public Vector2 _SettingsMenuPos;

	public void OpenSettings() {
		if (_SettingsMenuTarget.childCount != 0)
			return;

		GameObject SettingsMenu = Instantiate(_SettingsMenuPrefab);
		SettingsMenu.transform.SetParent(_SettingsMenuTarget);
		SettingsMenu.GetComponent<RectTransform>().anchoredPosition = _SettingsMenuPos;
	}
}
