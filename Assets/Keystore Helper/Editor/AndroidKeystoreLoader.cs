using UnityEngine;
using UnityEditor;
using System.IO;

#if UNITY_EDITOR

[InitializeOnLoad]
public class AndroidKeystoreLoader
{
	static AndroidKeystoreLoader()
	{
		string keystorePass, keyaliasName, keyaliasPass;
		
		keystorePass = AndroidKeystoreWindow.ReadPrefs(AndroidKeystoreWindow.KEYSTOREPASS);
		keyaliasName = AndroidKeystoreWindow.ReadPrefs(AndroidKeystoreWindow.KEYALIASNAME);
		keyaliasPass = AndroidKeystoreWindow.ReadPrefs(AndroidKeystoreWindow.KEYALIASPASS);
		
		PlayerSettings.Android.keystorePass = keystorePass;
		PlayerSettings.Android.keyaliasName = keyaliasName;
		PlayerSettings.Android.keyaliasPass = keyaliasPass;		
	}
}

#endif